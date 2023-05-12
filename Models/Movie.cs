using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public string? NameRu { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public string? NameEn { get; set; }
        public int KinopoiskId { get; set; }
        [MaxLength(20)]
        [MinLength(5)]
        public string? ImdbId { get; set; }
        [MaxLength(75)]
        [MinLength(5)]
        public string? Slogan { get; set; }
        [MaxLength(2000)]
        [MinLength(100)]
        public string? Description { get; set; }
        [MaxLength(500)]
        [MinLength(100)]
        public string? ShortDescription { get; set; }
        [MaxLength(1000)]
        public string PosterUrl { get; set; }
        public float? RatingKinopoisk { get; set; }
        public float? RatingImdb { get; set; }
        [MaxLength(1000)]
        public string WebUrl { get; set; }
        public int? Year { get; set; }
        public int? FilmLenght { get; set; }
        [MaxLength(75)]
        [MinLength(10)]
        public string? EditorAnnotation { get; set; }
        [MaxLength(20)]
        [MinLength(5)]
        public string? RatingAgeLimits { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Country> Countries { get; set; }
    }
}
