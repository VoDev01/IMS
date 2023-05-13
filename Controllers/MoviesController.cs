using IMS.Data;
using IMS.Models;
using IMS.Models.ResponseViewModels;
using IMS.Services;
using IMS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public MoviesController(ILogger<MoviesController> logger, ApplicationDbContext db)
        {
            this.logger = logger;
            this.db = db;
        }
        [Route("Movies/View/{id?}")]
        //[Route("Movies/View/{id?}/{country?}/{genre?}/{min_rating?}/{order?}/{min_date?}")]
        public IActionResult View(int? id)//, string? country, string? genre, float? min_rating, int? order, int? min_date)
        {
            Action<Task<Film>> ResponseToDb = async (content) => {
                var responseVal = content.Result;
                List<Genre> genresResponse = new List<Genre>();
                foreach (var item in responseVal.Genres)
                {
                    genresResponse.Add(new Genre { Name = item.Genre });
                }
                List<Country> countriesResponse = new List<Country>();
                foreach (var item in responseVal.Countries)
                {
                    countriesResponse.Add(new Country { Name = item.Country });
                }
                Movie movie = new Movie
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
                if (db.Movies.AnyAsync(m => m.KinopoiskId == movie.KinopoiskId).Result 
                || db.Movies.AnyAsync(m => m.ImdbId == movie.ImdbId).Result
                || db.Movies.AnyAsync(m => m.NameRu == movie.NameRu).Result)
                {
                    logger.LogWarning($"Database already has record {movie.NameRu}.");
                    return;
                }
                await db.Movies.AddAsync(movie);
                await db.SaveChangesAsync();
            };
            if (WebAPIConsume.Consume<Movie, Film>(
                $"films/{id}",
                db,
                ResponseToDb,
                logger))
            {
                MovieViewModel movieVM = new MovieViewModel();
                movieVM.Movies = db.Movies;
                movieVM.Countries = db.Countries;
                movieVM.Genres = db.Genres;

                return View(movieVM);
            }
            else
            {
                ModelState.AddModelError("", "Server error. Please contact administrator.");
                return View();
            }
        }
    }
}
