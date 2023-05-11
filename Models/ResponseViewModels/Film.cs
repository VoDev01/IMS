using IMS.Services;

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
        public ProductionStatusEnum? ProductionStatus { get; set; }
        public TypeEnum? Type { get; set; }
        public string? RatingMpaa { get; set; }
        public int? RatingAgeLimits { get; set; }
        public bool? HasImax { get; set; }
        public bool? Has3D { get; set; }
        public string LastSync { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public bool? Serial { get; set; }
        public bool? ShortFilm { get; set; }
        public bool? Completed { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Country> Countries { get; set; }

        public class ProductionStatusEnum : Enumeration
        {
            public static ProductionStatusEnum Filming => new(1, "FILMING");
            public static ProductionStatusEnum PreProduction => new(2, "PRE_PRODUCTION");
            public static ProductionStatusEnum Completed => new(3, "COMPLETED");
            public static ProductionStatusEnum Announced => new(4, "ANNOUNCED");
            public static ProductionStatusEnum Unknown => new(5, "UNKNOWN");
            public static ProductionStatusEnum PostProduction => new(6, "POST_PRODUCTION");
            public ProductionStatusEnum(int id, string name)
                : base(id, name)
            {
            }
        }
        public class TypeEnum : Enumeration
        {
            public static TypeEnum Film => new(1, "FILM");
            public static TypeEnum Video => new(2, "VIDEO");
            public static TypeEnum TvSeries => new(3, "TV_SERIES");
            public static TypeEnum MiniSeries => new(4, "MINI_SERIES");
            public static TypeEnum TvShow => new(5, "TV_SHOW");
            public TypeEnum(int id, string name)
                : base(id, name)
            {
            }
        }
    }
}
