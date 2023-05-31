using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserUrlId { get; set; }
        [Required(ErrorMessage = "Введите ваше имя")]
        [MaxLength(20)]
        [MinLength(2)]
        public string Name { get; set; }
        [MaxLength(20)]
        [MinLength(5)]
        public string? Surname { get; set; }
        [Required(ErrorMessage = "Введите логин")]
        [MaxLength(20)]
        [MinLength(5)]
        public string NickName { get; set; }
        [Required(ErrorMessage = "Введите ваш email")]
        [MaxLength(25)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        [MaxLength(30)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Введите вашу дату рождения")]
        public DateOnly BirthDate { get; set; }
        [Required(ErrorMessage = "Введите страну, в которой вы проживаете")]
        public Country Country { get; set; }
        public byte[] ProfilePicture { get; set; }
        public IEnumerable<Rating>? MoviesRatings { get; set; }
    }
}
