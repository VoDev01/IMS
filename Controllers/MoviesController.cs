using IMS.Data;
using IMS.Models;
using IMS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Net.Http.Headers;

namespace IMS.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ILogger<MoviesController> logger;

        public MoviesController(ILogger<MoviesController> logger, ApplicationDbContext context)
        {
            this.logger = logger;
            this.db = context;
        }

        public IActionResult View()
        {
            Filters filters = new Filters();

            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2");
                client.DefaultRequestHeaders.Add("X-API-KEY", "61be3fc1-0a02-4e86-ba4a-f902657c8ee8");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var filtersResponseTask = client.GetAsync("films/filters");
                filtersResponseTask.Wait();

                var filtersResult = filtersResponseTask.Result;
                if(filtersResult.IsSuccessStatusCode) 
                {
                    var content = filtersResult.Content.ReadFromJsonAsync<Filters>();
                    content.Wait();
                    filters = content.Result;
                    db.Countries.AddRange(filters.Countries);
                    db.Genres.AddRange(filters.Genres);
                    db.SaveChanges();
                }
                else
                {
                    logger.LogError(filtersResult.StatusCode.ToString() + " at " + filtersResult.RequestMessage.RequestUri.ToString());

                    filters = new Filters();

                    ModelState.AddModelError(string.Empty, "Server error. Please contanct administrator");
                }
            }

            return View();
        }

        public IActionResult View(string country, string genre, float min_rating, int order, int min_date)
        {
            IEnumerable<Movie> movies = null;

            using (var client = new HttpClient())
            {
                var moviesResponseTask = client.GetAsync("films");
                moviesResponseTask.Wait();

                var moviesResult = moviesResponseTask.Result;
                if (moviesResult.IsSuccessStatusCode)
                {
                    var content = moviesResult.Content.ReadFromJsonAsync<IEnumerable<Movie>>();
                    content.Wait();
                    movies = content.Result;
                    db.Movies.AddRange(movies);
                    db.SaveChanges();
                }
                else
                {
                    logger.LogError(moviesResult.StatusCode.ToString() + " at " + moviesResult.RequestMessage.RequestUri.ToString());

                    movies = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contanct administrator");
                }
            }
            MovieViewModel movieVM = new MovieViewModel();
            movieVM.Movies = movies;

            return View(movieVM);
        }

        private struct Filters
        {
            public IEnumerable<Country> Countries { get; set; }
            public IEnumerable<Genre> Genres { get; set; }
        }
    }
}
