using IMS.Models;

namespace IMS.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
