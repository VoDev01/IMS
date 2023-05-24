using IMS.Data;
using IMS.Models;
using IMS.Models.Interfaces;
using IMS.Models.ResponseViewModels;
using APIConsumeService;
using IMS.ViewModels;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IMS.Models.Repositories;

namespace IMS.Controllers
{
    public class MoviesController : Controller
    {
        private readonly string connectionString;
        private readonly ILogger<MoviesController> logger;
        public MoviesController(ILogger<MoviesController> logger)
        {
            this.logger = logger;
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            connectionString = configuration.GetConnectionString("Default");
        }
        [Route("Movies/Page/{id?}")]
        public IActionResult Page(string? id)
        {
            Func<Task<Film>, Task> ResponseToDb = async (content) =>
            {
                using (var db = new ApplicationDbContext(connectionString))
                {
                    IMoviesPages moviesPagesRepo = new MoviesPagesRepository(db);
                    IGenres genresRepo = new GenresRepository(db);
                    ICountries countriesRepo = new CountriesRepository(db);
                    using (var transaction = moviesPagesRepo.BeginTransaction())
                    {
                        try
                        {
                            var responseVal = content.Result;
                            if (moviesPagesRepo.IfAny(m => m.KinopoiskId == responseVal.KinopoiskId)
                            || moviesPagesRepo.IfAny(m => m.ImdbId == responseVal.ImdbId))
                            {
                                logger.LogWarning($"Database already has record {responseVal.NameRu}.");
                                transaction.Dispose();
                                return;
                            }
                            List<Genre> genresResponse = new List<Genre>();
                            foreach (var item in responseVal.Genres)
                            {
                                Genre? genre = genresRepo.FindSetByCondition(g => g.Name == item.Genre).FirstOrDefault();
                                if (genre == null)
                                {
                                    logger.LogWarning($"Requested genre {item.Genre} was not found in database");
                                    continue;
                                }
                                genresResponse.Add(genre);
                            }
                            List<Country> countriesResponse = new List<Country>();
                            foreach (var item in responseVal.Countries)
                            {
                                Country? country = countriesRepo.FindSetByCondition(c => c.Name == item.Country).FirstOrDefault();
                                if (country == null)
                                {
                                    logger.LogWarning($"Requested country {item.Country} was not found in database.");
                                    continue;
                                }
                                countriesResponse.Add(country);
                            }
                            if (countriesResponse.Count == 0 || genresResponse.Count == 0)
                            {
                                logger.LogError("Some data was not received from the request.");
                            }
                            MoviePage movie = new MoviePage
                            {
                                NameRu = responseVal.NameRu,
                                NameEn = responseVal.NameEn,
                                KinopoiskId = responseVal.KinopoiskId,
                                ImdbId = responseVal.ImdbId,
                                Slogan = responseVal.Slogan,
                                Description = responseVal.Description,
                                ShortDescription = responseVal.ShortDescription,
                                PosterUrl = responseVal.PosterUrl,
                                RatingImdb = responseVal.RatingImdb,
                                RatingKinopoisk = responseVal.RatingKinopoisk,
                                WebUrl = responseVal.WebUrl,
                                Year = responseVal.Year,
                                FilmLenght = responseVal.FilmLenght,
                                EditorAnnotation = responseVal.EditorAnnotation,
                                RatingAgeLimits = responseVal.RatingAgeLimits,
                                Genres = genresResponse,
                                Countries = countriesResponse
                            };
                            await moviesPagesRepo.CreateAsync(movie);
                            await moviesPagesRepo.SaveAsync();
                            transaction.Commit();
                        }
                        catch (Exception e)
                        {
                            logger.LogError(e.Message);
                            transaction.Rollback();
                            return;
                        }
                    }
                }
            };
            if (WebAPIConsume.Consume<MoviePage, Film>(
                    $"films/{id}",
                    ResponseToDb,
                    logger).Result)
            {
                using (var db = new ApplicationDbContext(connectionString))
                {
                    IMoviesPages moviesPagesRepo = new MoviesPagesRepository(db);
                    MoviePage? movie = null;
                    movie = moviesPagesRepo.FindSetByCondition(m => m.KinopoiskId == Convert.ToInt32(id) || m.ImdbId == id).FirstOrDefault();
                    if (movie != null)
                        return View(movie);
                    else
                    {
                        ModelState.AddModelError("MoviePage", "Requested movie was not found.");
                        return View();
                    }
                }
            }
            else
            {
                ModelState.AddModelError("MoviePage", "Server error. Please contact administrator.");
                return View();
            }
        }
        [Route("Movies/Pages")]
        [Route("Movies/Pages/{country?}/{genre?}/{order?}/{type?}/{imdbid?}/{keyword?}/{min_rating?}/{max_rating?}/{min_year?}/{max_year?}/{page?}")]
        [Route("Movies/Pages/{page}")]
        public async Task<IActionResult> Pages(string? imdbid = "", string? keyword = "",
            int? country = 1, int? genre = 1,
            string? order = "RATING", string? type = "ALL",
            int? min_rating = 0, int? max_rating = 10,
            int? min_year = 1000, int? max_year = 3000,
            int page = 1)
        {
            MoviePageItemViewModel moviePageItemsVM = new MoviePageItemViewModel();
            moviePageItemsVM.MoviePageItems = new List<MoviePageItem>();
            moviePageItemsVM.Countries = new List<Country>();
            moviePageItemsVM.Genres = new List<Genre>();

            Func<Task<FilmSearchByFiltersResponse>, Task> ResponseToDb = async (content) => {
                using (var db = new ApplicationDbContext(connectionString))
                {
                    IMoviesItems moviesItemsRepo = new MoviesItemsRepository(db);
                    IGenres genresRepo = new GenresRepository(db);
                    ICountries countriesRepo = new CountriesRepository(db);
                    using (var transaction = moviesItemsRepo.BeginTransaction())
                    {
                        try
                        {
                            var responseVal = content.Result;
                            moviePageItemsVM.Total = responseVal.Total;
                            moviePageItemsVM.TotalPages = responseVal.TotalPages;
                            foreach (var movieItem in responseVal.Items)
                            {
                                if (moviesItemsRepo.IfAny(m => m.KinopoiskId == movieItem.KinopoiskId)
                                || moviesItemsRepo.IfAny(m => m.ImdbId == movieItem.ImdbId))
                                {
                                    logger.LogWarning($"Database already has record {movieItem.NameRu}.");
                                    continue;
                                }
                                List<Genre> genresResponse = new List<Genre>();
                                foreach (var item in movieItem.Genres)
                                {
                                    Genre? genre = genresRepo.FindSetByCondition(g => g.Name == item.Genre).FirstOrDefault();
                                    if (genre == null)
                                    {
                                        logger.LogWarning($"Requested genre {item.Genre} was not found in database");
                                        continue;
                                    }
                                    genresResponse.Add(genre);
                                }
                                List<Country> countriesResponse = new List<Country>();
                                foreach (var item in movieItem.Countries)
                                {
                                    Country? country = countriesRepo.FindSetByCondition(c => c.Name == item.Country).FirstOrDefault();
                                    if (country == null)
                                    {
                                        logger.LogWarning($"Requested country {item.Country} was not found in database.");
                                        continue;
                                    }
                                    countriesResponse.Add(country);
                                }
                                if (countriesResponse.Count == 0 || genresResponse.Count == 0)
                                {
                                    logger.LogError("Some data was not received from the request.");
                                }
                                MoviePageItem movieItemObj = new MoviePageItem
                                {
                                    NameRu = movieItem.NameRu,
                                    NameEn = movieItem.NameEn,
                                    KinopoiskId = movieItem.KinopoiskId,
                                    ImdbId = movieItem.ImdbId,
                                    PosterUrl = movieItem.PosterUrl,
                                    PosterUrlPreview = movieItem.PosterUrlPreview,
                                    RatingImdb = movieItem.RatingImdb,
                                    RatingKinopoisk = movieItem.RatingKinopoisk,
                                    Year = movieItem.Year,
                                    Type = movieItem.Type.ToString(),
                                    Genres = genresResponse,
                                    Countries = countriesResponse,
                                    PageIndex = page,
                                };
                                await moviesItemsRepo.CreateAsync(movieItemObj);
                            }
                            await moviesItemsRepo.SaveAsync();
                            transaction.Commit();
                            return;
                        }
                        catch (Exception e)
                        {
                            logger.LogError(e.Message);
                            transaction.Rollback();
                            return;
                        }
                    }
                }
            };
            Dictionary<string, string> queryStrKeyValue = new Dictionary<string, string>
            {
                { "countries", country.ToString() ?? string.Empty },
                { "genres", genre.ToString() ?? string.Empty },
                { "order", order ?? string.Empty },
                { "type", type ?? string.Empty },
                { "ratingFrom", min_rating.ToString() ?? string.Empty },
                { "ratingTo", max_rating.ToString() ?? string.Empty },
                { "yearFrom", min_year.ToString() ?? string.Empty },
                { "yearTo", max_year.ToString() ?? string.Empty },
                { "imdbid", string.Empty },
                { "keyword", string.Empty },
                { "page", page.ToString() ?? string.Empty }
            };
            QueryBuilder queryBuilder = new QueryBuilder(queryStrKeyValue);
            if (await WebAPIConsume.Consume<MoviePage, FilmSearchByFiltersResponse>(
                $"films/" + queryBuilder.ToQueryString().Value,
                ResponseToDb,
                logger))
            {
                using (var db = new ApplicationDbContext(connectionString))
                {
                    try
                    {
                        IMoviesItems moviesItemsRepo = new MoviesItemsRepository(db);
                        IGenres genresRepo = new GenresRepository(db);
                        ICountries countriesRepo = new CountriesRepository(db);

                        IEnumerable<MoviePageItem> movieItems =
                        moviesItemsRepo.
                        GetAllWithInclude(m => m.Genres)
                        .Include(m => m.Countries)
                        .Where(mi => page == mi.PageIndex && mi.Genres.Any(g => g.Id == genre) && mi.Countries.Any(c => c.Id == country)).ToList();

                        moviePageItemsVM.MoviePageItems = movieItems;
                        moviePageItemsVM.Countries = countriesRepo.GetAll().ToList();
                        moviePageItemsVM.Genres = genresRepo.GetAll().ToList();

                        if(moviePageItemsVM.MoviePageItems.Count() != 0)
                            return View(moviePageItemsVM);
                        else
                        {
                            ModelState.AddModelError("MoviePageItems", "Requested pages were not found.");
                            return View(moviePageItemsVM);
                        }
                    }
                    catch (Exception e)
                    {
                        logger.LogError(e.Message);
                        ModelState.AddModelError("MoviePageItems", "Requested pages were not found.");
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("MoviePageItems", "Server error. Please contact administrator.");
                return RedirectToAction("Pages", "Movies", new { page = 1 });
            }
        }
        [Route("Movies/Pages")]
        [Route("Movies/Pages/{country?}/{genre?}/{order?}/{type?}/{imdbid?}/{keyword?}/{min_rating?}/{max_rating?}/{min_year?}/{max_year?}/{page?}")]
        [HttpPost]
        public IActionResult PostPages(string? imdbid = "", string? keyword = "",
            int? country = 1, int? genre = 1,
            string? order = "RATING", string? type = "ALL",
            int? min_rating = 0, int? max_rating = 10,
            int? min_year = 1000, int? max_year = 3000,
            int page = 1)
        {
            return RedirectToAction("Pages", "Movies", new
            {
                imdbid,
                keyword,
                country,
                genre,
                order,
                type,
                min_rating,
                max_rating,
                min_year,
                max_year,
                page
            });
        }
    }
}
