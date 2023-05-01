using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }
        public string? Slogan { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public string? PosterUrl { get; set; }
        public float RatingKinopoisk { get; set; }
        public float RatingImdb { get; set; }
        public string? WebUrl { get; set; }
        public int Year { get; set; }
        public int FilmLenght { get; set; }
        public string? EditorAnnotation { get; set; }
        public int RatingAgeLimits { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
