using IMS.Services;
using System.Text.Json.Serialization;

namespace IMS.Models.ResponseViewModels
{
    public class Film
    {
        public int KinopoiskId { get; set; }
        public string? ImdbId { get; set; }
        public string? NameRu { get; set; }
        public string? NameEn { get; set; }
        public string? NameOriginal { get; set; }
        public string PosterUrl { get; set; }
        public string PosterUrlPreview { get; set; }
        public string CoverUrl { get; set; }
        public string? LogoUrl { get; set; }
        public int ReviewsCount { get; set; }
        public float? RatingGoodReview { get; set; }
        public int? RatingGoodReviewVoteCount { get; set; }
        public float? RatingKinopoisk { get; set; }
        public int? RatingKinopoiskVoteCount { get; set; }
        public float? RatingImdb { get; set; }
        public int? RatingImdbVoteCount { get; set; }
        public float? RatingFilmCritics { get; set; }
        public int? RatingFilmCriticsVoteCount { get; set; }
        public float? RatingAwait { get; set; }
        public int? RatingAwaitCount { get; set; }
        public float? RaitingRfCritics { get; set; }
        public int? RaitingRfCriticsVoteCount { get; set; }
        public string WebUrl { get; set; }
        public int? Year { get; set; }
        public int? FilmLenght { get; set; }
        public string? Slogan { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public string? EditorAnnotation { get; set; }
        public bool IsTicketsAvailable { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProductionStatusEnum? ProductionStatus { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeEnum? Type { get; set; }
        public string? RatingMpaa { get; set; }
        public string? RatingAgeLimits { get; set; }
        public bool? HasImax { get; set; }
        public bool? Has3D { get; set; }
        public string LastSync { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public bool? Serial { get; set; }
        public bool? ShortFilm { get; set; }
        public bool? Completed { get; set; }
        public IEnumerable<GenreResponse> Genres { get; set; }
        public IEnumerable<CountryResponse> Countries { get; set; }
        public enum ProductionStatusEnum { FILMING, PRE_PRODUCTION, COMPLETED, ANNOUNCED, UNKNOWN, POST_PRODUCTION }
        public enum TypeEnum { FILM, VIDEO, TV_SERIES, MINI_SERIES, TV_SHOW }
        public class CountryResponse
        {
            public string Country { get; set; }
        }
        public class GenreResponse
        {
            public string Genre { get; set; }
        }
    }
}
