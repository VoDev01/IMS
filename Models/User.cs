using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string Name { get; set; }
        [MaxLength(20)]
        [MinLength(5)]
        public string? Surname { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string NickName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        public DateOnly BirthDate { get; set; }
        public Country Country { get; set; }
        public IEnumerable<Rating>? MoviesRatings { get; set; }
    }
}
