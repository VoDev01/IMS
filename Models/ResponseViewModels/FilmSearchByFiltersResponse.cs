using System.Text.Json.Serialization;

namespace IMS.Models.ResponseViewModels
{
    public class FilmSearchByFiltersResponse
    {
        public int Total { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<FilmSearchByFiltersResponse_items> Items { get; set; }
        public class FilmSearchByFiltersResponse_items
        {
            public int KinopoiskId { get; set; }
            public string? ImdbId { get; set; }
            public string? NameRu { get; set; }
            public string? NameEn { get; set; }
            public string? NameOriginal { get; set; }
            public IEnumerable<Film.CountryResponse> Countries { get; set; }
            public IEnumerable<Film.GenreResponse> Genres { get; set; }
            public float? RatingKinopoisk { get; set; }
            public float? RatingImdb { get; set; }
            public int? Year { get; set; }
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public Film.TypeEnum Type { get; set; }
            public string PosterUrl { get; set; }
            public string PosterUrlPreview { get; set; }
        }
    }
}
