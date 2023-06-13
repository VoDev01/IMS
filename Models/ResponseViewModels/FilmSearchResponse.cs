using System.Text.Json.Serialization;

namespace IMS.Models.ResponseViewModels
{
    public class FilmSearchResponse
    {
        public string Keyword { get; set; }
        public int PagesCount { get; set; }
        public int SearchFilmsCountResult { get; set; }
        public IEnumerable<FilmSearchResponse_films> Films { get; set; }
        public class FilmSearchResponse_films
        {
            public int FilmId { get; set; }
            public string NameRu { get; set; }
            public string NameEn { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public string Description { get; set; }
            public string FilmLength { get; set; }
            public IEnumerable<Film.GenreResponse> Genres { get; set; }
            public IEnumerable<Film.CountryResponse> Countries { get; set; }
            public string Rating { get; set; }
            public int RatingVoteCount { get; set; }
            public string PosterUrl { get; set; }
            public string PosterUrlPreview { get; set; }
        }
    }
}
