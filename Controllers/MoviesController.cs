﻿using IMS.Data;
using IMS.Models;
using IMS.Models.Interfaces;
using IMS.Models.ResponseViewModels;
using APIConsumeService;
using IMS.ViewModels;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IMS.Models.Repositories;
using System.Globalization;

namespace IMS.Controllers
{
    public class MoviesController : Controller
    {
        private readonly string connectionString;
        private readonly ILogger<MoviesController> logger;
        private readonly int maxMoviesAtPage = 20;
        public MoviesController(ILogger<MoviesController> logger)
        {
            this.logger = logger;
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            connectionString = configuration.GetConnectionString("Default");
        }
        [Route("Movies/Page/{id?}")]
        //Single-page action that can be accessed by putting in the id of the movie
        public IActionResult Page(string? id)
        {
            Func<Task<Film>, Task> ResponseToDb = async (content) => //A func that contains interaction with web api
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
                                PosterUrlPreview = responseVal.PosterUrlPreview,
                                CoverUrl = responseVal.CoverUrl,
                                RatingImdb = responseVal.RatingImdb,
                                RatingImdbVoteCount = responseVal.RatingImdbVoteCount,
                                RatingKinopoisk = responseVal.RatingKinopoisk,
                                RatingKinopoiskVoteCount = responseVal.RatingKinopoiskVoteCount,
                                WebUrl = responseVal.WebUrl,
                                Year = responseVal.Year,
                                StartYear = responseVal.StartYear,
                                EndYear = responseVal.EndYear,
                                Type = responseVal.Type.ToString(),
                                ProductionStatus = responseVal.ProductionStatus.ToString(),
                                FilmLenght = responseVal.FilmLenght,
                                EditorAnnotation = responseVal.EditorAnnotation,
                                RatingAgeLimits = responseVal.RatingAgeLimits,
                                LastSync = responseVal.LastSync,
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
                    logger).Result 
                    && ModelState.IsValid)
            {
                using (var db = new ApplicationDbContext(connectionString))
                {
                    IMoviesPages moviesPagesRepo = new MoviesPagesRepository(db);
                    MoviePage? movie = null;
                    movie = moviesPagesRepo.FindSetByCondition(m => m.KinopoiskId.ToString() == id || m.ImdbId == id).FirstOrDefault();
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
        [HttpPost]
        [Route("Movies/PageRating")]
        public IActionResult PageRating(int rating, int movieid)
        {
            return RedirectToAction("SetMovieRating", "User", new { rating, movieid });
        }
        [Route("Movies/Pages")]
        //A GET action that loads movies pages from API (if not present in database) and puts it to view 
        public async Task<IActionResult> Pages(MoviePageItemViewModel moviePageItemsVM, int page = 1)
        {
            Func<Task<FilmSearchByFiltersResponse>, Task> ResponseToDb = async (content) =>
            {
                //A func that contains interaction with web api
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
                            int counter = 0;
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
                                    PageIndex = page
                                };
                                counter++;
                                await moviesItemsRepo.CreateAsync(movieItemObj);
                            }
                            logger.LogInformation($"Movies fetched: {counter}");
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
                { "countries", moviePageItemsVM.Country.ToString() ?? string.Empty },
                { "genres", moviePageItemsVM.Genre.ToString() ?? string.Empty },
                { "order", moviePageItemsVM.Order ?? string.Empty },
                { "type", moviePageItemsVM.Type ?? string.Empty },
                { "ratingFrom", MathF.Floor(moviePageItemsVM.MinRating ?? 0).ToString() ?? string.Empty },
                { "ratingTo",  MathF.Floor(moviePageItemsVM.MaxRating ?? 0).ToString() ?? string.Empty },
                { "yearFrom", moviePageItemsVM.MinYear.ToString() ?? string.Empty },
                { "yearTo", moviePageItemsVM.MaxYear.ToString() ?? string.Empty },
                { "imdbid", moviePageItemsVM.Imdbid ?? string.Empty },
                { "keyword", moviePageItemsVM.Keyword ?? string.Empty },
                { "page", page.ToString() ?? string.Empty }
            };
            QueryBuilder queryBuilder = new QueryBuilder(queryStrKeyValue);
            if (await WebAPIConsume.Consume<MoviePage, FilmSearchByFiltersResponse>(
                $"films/{queryBuilder.ToQueryString().Value}",
                ResponseToDb,
                logger) 
                && ModelState.IsValid)
            {
                using (var db = new ApplicationDbContext(connectionString))
                {
                    try
                    {
                        IMoviesItems moviesItemsRepo = new MoviesItemsRepository(db);
                        IGenres genresRepo = new GenresRepository(db);
                        ICountries countriesRepo = new CountriesRepository(db);

                        IEnumerable<MoviePageItem> movieItems;
                        if (moviePageItemsVM.Keyword != string.Empty)
                        {
                            movieItems =
                            moviesItemsRepo
                            .GetAllWithInclude(m => m.Genres)
                            .Include(m => m.Countries)
                            .ToList()
                            .Where(mi => page == mi.PageIndex
                            && mi.Countries.Any(c => c.Id == moviePageItemsVM.Country)
                            && mi.Genres.Any(g => g.Id == moviePageItemsVM.Genre)
                            && mi.NameRu.Contains(moviePageItemsVM.Keyword));
                        }
                        else
                        {
                            movieItems =
                            moviesItemsRepo
                            .GetAllWithInclude(m => m.Genres)
                            .Include(m => m.Countries)
                            .ToList()
                            .Where(mi => page == mi.PageIndex
                            && mi.Countries.Any(c => c.Id == moviePageItemsVM.Country)
                            && mi.Genres.Any(g => g.Id == moviePageItemsVM.Genre));
                        }

                        List<MoviePageItem> movieItemsList = movieItems.ToList();

                        /*if (movieItemsList.Count() > maxMoviesAtPage) //This code executes when returned movies count is greater that maximum amount of movies that
                        {                                               //can be present at page and puts every movies that exceeds constrait to the very last page
                            for(int i = 0;i < movieItemsList.Count();i++) 
                            {
                                if(i > maxMoviesAtPage)
                                {
                                    MoviePageItem moviePageItem = movieItemsList[i];
                                    moviePageItem.PageIndex += moviePageItemsVM.TotalPages;
                                    moviesItemsRepo.Update(moviePageItem);
                                }
                            }
                            movieItemsList.RemoveRange(maxMoviesAtPage, movieItemsList.Count() - maxMoviesAtPage);
                            moviePageItemsVM.Total += maxMoviesAtPage;
                            moviesItemsRepo.Save();
                        }*/

                        moviePageItemsVM.MoviePageItems = movieItemsList;
                        moviePageItemsVM.Countries = countriesRepo.GetAll().ToList();
                        moviePageItemsVM.Genres = genresRepo.GetAll().ToList();

                        if (moviePageItemsVM.MoviePageItems.Count() != 0 && ModelState.IsValid)
                        {
                            ModelState.Clear();
                            return View(moviePageItemsVM);
                        }
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
                        return RedirectToAction("Error", "Home");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("MoviePageItems", "Server error. Please contact administrator.");
                return RedirectToAction("Pages", "Movies", new { page = 1 });
            }
        }
        [Route("Movies/PagesSearchQuery")]
        //A GET action that searches for movies by keyword then loads movies from API (if not present in database) and puts it to view  
        public async Task<IActionResult> PagesSearchQuery(string searchQuery = "", int page = 1)
        {
            MoviePageItemViewModel moviePageItemsVM = new MoviePageItemViewModel();
            Func<Task<FilmSearchResponse>, Task> ResponseToDb = async (content) => { //A func that contains interaction with web api
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
                            moviePageItemsVM.Total = responseVal.SearchFilmsCountResult;
                            moviePageItemsVM.TotalPages = responseVal.PagesCount;
                            moviePageItemsVM.Keyword = responseVal.Keyword;
                            int counter = 0;
                            foreach (var movieItem in responseVal.Films)
                            {
                                if (moviesItemsRepo.IfAny(m => m.KinopoiskId == movieItem.FilmId))
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
                                float rating = float.Parse(movieItem.Rating.Contains('%') ? "0.0" : movieItem.Rating, CultureInfo.InvariantCulture.NumberFormat);
                                MoviePageItem movieItemObj = new MoviePageItem
                                {
                                    NameRu = movieItem.NameRu,
                                    NameEn = movieItem.NameEn,
                                    KinopoiskId = movieItem.FilmId,
                                    PosterUrl = movieItem.PosterUrl,
                                    PosterUrlPreview = movieItem.PosterUrlPreview,
                                    RatingKinopoisk = rating,
                                    Year = Convert.ToInt32(movieItem.Year),
                                    Type = movieItem.Type,
                                    Genres = genresResponse,
                                    Countries = countriesResponse,
                                    PageIndex = page
                                };
                                counter++;
                                await moviesItemsRepo.CreateAsync(movieItemObj);
                            }
                            logger.LogInformation($"Movies fetched: {counter}");
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
                { "keyword", searchQuery },
                { "page", page.ToString() ?? string.Empty }
            };
            QueryBuilder queryBuilder = new QueryBuilder(queryStrKeyValue);
            WebAPIConsume.ConfigureRequestHeaders("https://kinopoiskapiunofficial.tech/api/v2.1/");
            if (await WebAPIConsume.Consume<MoviePage, FilmSearchResponse>(
                $"films/search-by-keyword{queryBuilder.ToQueryString().Value}",
                ResponseToDb,
                logger)
                && ModelState.IsValid)
            {
                WebAPIConsume.ConfigureRequestHeaders("https://kinopoiskapiunofficial.tech/api/v2.2/");
                using (var db = new ApplicationDbContext(connectionString))
                {
                    try
                    {
                        IMoviesItems moviesItemsRepo = new MoviesItemsRepository(db);
                        IGenres genresRepo = new GenresRepository(db);
                        ICountries countriesRepo = new CountriesRepository(db);

                        IEnumerable<MoviePageItem> movieItems =
                        moviesItemsRepo
                        .GetAllWithInclude(m => m.Genres)
                        .Include(m => m.Countries)
                        .ToList()
                        .Where(mi => page == mi.PageIndex
                        && mi.Countries.Any(c => c.Id == moviePageItemsVM.Country)
                        && mi.Genres.Any(g => g.Id == moviePageItemsVM.Genre));

                        List<MoviePageItem> movieItemsList = movieItems.ToList();

                        /*if (movieItemsList.Count() > maxMoviesAtPage) //This code executes when returned movies count is greater that maximum amount of movies that
                        {                                               //can be present at page and puts every movies that exceeds constrait to the very last page
                            for(int i = 0;i < movieItemsList.Count();i++) 
                            {
                                if(i > maxMoviesAtPage)
                                {
                                    MoviePageItem moviePageItem = movieItemsList[i];
                                    moviePageItem.PageIndex += moviePageItemsVM.TotalPages;
                                    moviesItemsRepo.Update(moviePageItem);
                                }
                            }
                            movieItemsList.RemoveRange(maxMoviesAtPage, movieItemsList.Count() - maxMoviesAtPage);
                            moviePageItemsVM.Total += maxMoviesAtPage;
                            moviesItemsRepo.Save();
                        }*/

                        moviePageItemsVM.MoviePageItems = movieItemsList;
                        moviePageItemsVM.Countries = countriesRepo.GetAll().ToList();
                        moviePageItemsVM.Genres = genresRepo.GetAll().ToList();

                        if (moviePageItemsVM.MoviePageItems.Count() != 0 && ModelState.IsValid)
                        {
                            ModelState.Clear();
                            return RedirectToAction("Pages", "Movies", new { moviePageItemsVM, page });
                        }
                        else
                        {
                            ModelState.AddModelError("MoviePageItems", "Requested pages were not found.");
                            return RedirectToAction("Pages", "Movies", new { moviePageItemsVM, page });
                        }
                    }
                    catch (Exception e)
                    {
                        logger.LogError(e.Message);
                        ModelState.AddModelError("MoviePageItems", "Requested pages were not found.");
                        return RedirectToAction("Error", "Home");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("MoviePageItems", "Server error. Please contact administrator.");
                return RedirectToAction("Pages", "Movies", new { page = 1 });
            }
        }
        [Route("Movies/PostPages")]
        [HttpPost]
        public IActionResult PostPages(MoviePageItemViewModel moviePageItemVM)
        {
            return RedirectToAction("Pages", "Movies", moviePageItemVM);
        }
        [Route("Movies/PostSearchPages")]
        [HttpPost]
        public IActionResult PostSearchPages(string searchquery)
        {
            return RedirectToAction("PagesSearchQuery", "Movies", new { searchQuery = searchquery });
        }
    }
}
