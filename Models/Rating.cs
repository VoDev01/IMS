using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int RatingNum { get; set; }
        public string MovieName { get; set; }
        public DateTime RatingDate { get; set; } = DateTime.Now;
        public string? RatingComment { get; set; }
    }
}
