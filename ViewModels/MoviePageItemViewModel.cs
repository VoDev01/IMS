using IMS.Models;

namespace IMS.ViewModels
{
    public class MoviePageItemViewModel
    {
        public IEnumerable<MoviePageItem> MoviePageItems { get; set; } = Enumerable.Empty<MoviePageItem>();
        public IEnumerable<Country> Countries { get; set; } = Enumerable.Empty<Country>();
        public IEnumerable<Genre> Genres { get; set; } = Enumerable.Empty<Genre>();
        public int Genre { get; set; } = 1;
        public int Country { get; set; } = 1;
        public string? Imdbid { get; set; } = "";
        public string? Keyword { get; set; } = "";
        public string? Order { get; set; } = "RATING";
        public string? Type { get; set; } = "ALL";
        public float? MinRating { get; set; } = 0.0f;
        public float? MaxRating { get; set; } = 10.0f;
        public int? MinYear { get; set; } = 1000;
        public int? MaxYear { get; set; } = 3000;
        public int Page { get; set; } = 1;
        public int Total { get; set; }
        public int TotalPages { get; set; }
    }
}
