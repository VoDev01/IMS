using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int RatingNum { get; set; }
        public MoviePage Movie { get; set; }
        [MaxLength(10000)]
        [MinLength(10)]
        public string? RatingComment { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
