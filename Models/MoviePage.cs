using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class MoviePage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? NameRu { get; set; }
        [MaxLength(50)]
        public string? NameEn { get; set; }
        public int KinopoiskId { get; set; }
        [MaxLength(40)]
        public string? ImdbId { get; set; }
        [MaxLength(75)]
        public string? Slogan { get; set; }
        [MaxLength(2000)]
        public string? Description { get; set; }
        [MaxLength(500)]
        public string? ShortDescription { get; set; }
        [MaxLength(1000)]
        public string PosterUrl { get; set; } = null!;
        [MaxLength(1000)]
        public string PosterUrlPreview { get; set; } = null!;
        [MaxLength(1000)]
        public string? CoverUrl { get; set; } = null!;

        public int ReviewsCount { get; set; }

        public float? RatingKinopoisk { get; set; }

        public int? RatingKinopoiskVoteCount { get; set; }

        public float? RatingImdb { get; set; }

        public int? RatingImdbVoteCount { get; set; }
        [MaxLength(1000)]
        public string WebUrl { get; set; } = null!;

        public int? Year { get; set; }

        public int? StartYear { get; set; }

        public int? EndYear { get; set; }

        public int? FilmLenght { get; set; }
        [MaxLength(50)]
        public string? Type { get; set; }
        [MaxLength(50)]
        public string? ProductionStatus { get; set; }
        [MaxLength(250)]
        public string LastSync { get; set; } = null!;
        [MaxLength(75)]
        public string? EditorAnnotation { get; set; }
        [MaxLength(20)]
        public string? RatingAgeLimits { get; set; }
        public virtual IEnumerable<Rating> Ratings { get; set; } = new List<Rating>();

        public virtual IEnumerable<Country> Countries { get; set; } = new List<Country>();

        public virtual IEnumerable<Genre> Genres { get; set; } = new List<Genre>();
    }
}
