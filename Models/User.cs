using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Surname { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Country { get; set; }
        public Rating Rating { get; set; }
    }
}
