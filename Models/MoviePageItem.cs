using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class MoviePageItem
    {
        [Key]
        public int Id { get; set; }
        public int KinopoiskId { get; set; }
        [MaxLength(20)]
        [MinLength(5)]
        public string? ImdbId { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public string? NameRu { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public string? NameEn { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public string? NameOriginal { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public float? RatingKinopoisk { get; set; }
        public float? RatingImdb { get; set; }
        public int? Year { get; set; }
        [MaxLength(25)]
        public string? Type { get; set; }
        [MaxLength(1000)]
        public string PosterUrl { get; set; }
        [MaxLength(1000)]
        public string PosterUrlPreview { get; set; }
        public int PageIndex { get; set; }
    }
}
