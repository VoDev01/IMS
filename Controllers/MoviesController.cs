using IMS.Data;
using IMS.Models;
using IMS.Models.ResponseViewModels;
using IMS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NuGet.Packaging;
using System.Net.Http.Headers;
using System.Transactions;

namespace IMS.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ILogger<MoviesController> logger;
        private string defaultCountry;
        private string defaultGenre;

        public MoviesController(ILogger<MoviesController> logger, ApplicationDbContext context)
        {
            this.logger = logger;
            this.db = context;
        }
        [Route("Movies/View")]
        public IActionResult View()
        {
            if (db.Countries.Count() != 0 && db.Genres.Count() != 0)
                return RedirectToAction("View", new { id = 301 });

            using(var client = new HttpClient())
            {
                FiltersResponse filtersResponse = new FiltersResponse();
                client.BaseAddress = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2/");
                client.DefaultRequestHeaders.Add("X-API-KEY", "61be3fc1-0a02-4e86-ba4a-f902657c8ee8");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var filtersResponseTask = client.GetAsync("films/filters");
                filtersResponseTask.Wait();

                var filtersResult = filtersResponseTask.Result;
                if (filtersResult.IsSuccessStatusCode)
                {
                    var content = filtersResult.Content.ReadFromJsonAsync<FiltersResponse>();
                    content.Wait();
                    filtersResponse = content.Result;
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            defaultCountry = filtersResponse.Countries.FirstOrDefault().Country;
                            defaultGenre = filtersResponse.Genres.FirstOrDefault().Genre;
                            if (db.Countries.Count() == 0)
                            {
                                foreach (var responseVal in filtersResponse.Countries)
                                {
                                    db.Countries.Add(new Country { Name = responseVal.Country });
                                }
                            }
                            if (db.Genres.Count() == 0)
                            {
                                foreach (var responseVal in filtersResponse.Genres)
                                {
                                    db.Genres.Add(new Genre { Name = responseVal.Genre });
                                }
                            }
                            db.SaveChanges();
                        }
                        catch(Exception ex) 
                        {
                            logger.LogError(ex.Message);
                            transaction.Rollback();
                            return RedirectToAction("Index", "Home");
                        }
                        transaction.Commit();
                    }
                }
                else
                {
                    logger.LogError(filtersResult.StatusCode.ToString() + " at " + filtersResult.RequestMessage.RequestUri.ToString());

                    filtersResponse = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contanct administrator");
                }
            }

            return View();
        }
        [Route("Movies/View/{id?}")]
        [Route("Movies/View/{id?}/{country?}/{genre?}/{min_rating?}/{order?}/{min_date?}")]
        public IActionResult View(int? id, string? country, string? genre, float? min_rating, int? order, int? min_date)
        {
            List<Movie> movies = new List<Movie>();

            using (var client = new HttpClient())
            {
                //Dictionary<string, string?> queryDictionary = new Dictionary<string, string?>
                //{
                //    { nameof(id), id.ToString() }
                //};
                //QueryString queryString = QueryString.Create(queryDictionary);

                client.BaseAddress = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2/");
                client.DefaultRequestHeaders.Add("X-API-KEY", "61be3fc1-0a02-4e86-ba4a-f902657c8ee8");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var moviesResponseTask = client.GetAsync($"films/{id}");
                moviesResponseTask.Wait();

                var moviesResult = moviesResponseTask.Result;
                if (moviesResult.IsSuccessStatusCode)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var content = moviesResult.Content.ReadFromJsonAsync<Film>();
                            content.Wait();
                            //foreach (var responseVal in content.Result)
                            //{
                            //    movies.Add(new Movie
                            //    {
                            //        NameRu = responseVal.NameRu,
                            //        NameEn = responseVal.NameEn,
                            //        KinopoiskId = responseVal.KinopoiskId,
                            //        ImdbId = responseVal.ImdbId,
                            //        Slogan = responseVal.Slogan,
                            //        Description = responseVal.Description,
                            //        ShortDescription = responseVal.ShortDescription,
                            //        PosterUrl = responseVal.PosterUrl,
                            //        RatingImdb = responseVal.RatingImdb,
                            //        RatingKinopoisk = responseVal.RatingKinopoisk,
                            //        WebUrl = responseVal.WebUrl,
                            //        Year = responseVal.Year,
                            //        FilmLenght = responseVal.FilmLenght,
                            //        EditorAnnotation = responseVal.EditorAnnotation,
                            //        RatingAgeLimits = responseVal.RatingAgeLimits,
                            //        Genres = responseVal.Genres,
                            //        Countries = responseVal.Countries

                            //    });
                            //}
                            var responseVal = content.Result;
                            List<Genre> genresResponse = new List<Genre>();
                            foreach(var item in responseVal.Genres) 
                            {
                                genresResponse.Add(new Genre { Name = item.Genre });
                            }
                            List<Country> countriesResponse = new List<Country>();
                            foreach (var item in responseVal.Countries)
                            {
                                countriesResponse.Add(new Country { Name = item.Country });
                            }
                            movies.Add(new Movie
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

                            });
                            db.Movies.AddRange(movies.AsEnumerable());
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            logger.LogError(ex.Message);
                            transaction.Rollback();
                            return RedirectToAction("Index", "Home");
                        }
                        transaction.Commit();
                    }
                }
                else
                {
                    logger.LogError(moviesResult.StatusCode.ToString() + " at " + moviesResult.RequestMessage.RequestUri.ToString());

                    movies = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contanct administrator");
                }
            }
            MovieViewModel movieVM = new MovieViewModel();
            movieVM.Movies = db.Movies;
            movieVM.Countries = db.Countries;
            movieVM.Genres = db.Genres;

            return View(movieVM);
        }
    }
}
