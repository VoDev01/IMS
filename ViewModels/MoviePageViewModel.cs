using IMS.Models;

namespace IMS.ViewModels
{
    public class MoviePageViewModel
    {
        public IEnumerable<MoviePage> MoviesPages { get; set; } = Enumerable.Empty<MoviePage>();
        public IEnumerable<Country> Countries { get; set; } = Enumerable.Empty<Country>();
        public IEnumerable<Genre> Genres { get; set; } = Enumerable.Empty<Genre>();
    }
}
