using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CustomValidationAttributes;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? UserUrlId { get; set; } = $"User{new Random().Next()}";
        [Required(ErrorMessage = "Введите ваше имя")]
        [MaxLength(20, ErrorMessage = "Длина имени не должна превышать 20 символов")]
        [MinLength(2, ErrorMessage = "Длина имени не должна быть менее 2 символов")]
        public string Name { get; set; }
        [MaxLength(20, ErrorMessage = "Длина фамилии не должна превышать 20 символов")]
        [MinLength(5, ErrorMessage = "Длина фамилии не должна быть менее 5 символов")]
        public string? Surname { get; set; }
        [Required(ErrorMessage = "Введите логин")]
        [MaxLength(20, ErrorMessage = "Длина логина не должна превышать 20 символов")]
        [MinLength(5, ErrorMessage = "Длина логина не должна быть менее 5 символов")]
        [Remote("CheckNickName", "User", ErrorMessage = "Данный логин уже кем-то занят")]
        public string NickName { get; set; }
        [Required(ErrorMessage = "Введите ваш email")]
        [MaxLength(35, ErrorMessage = "Длина email не должна превышать 35 символов")]
        [EmailAddress(ErrorMessage = "Не соответсвует email адресу")]
        [Remote("CheckEmail", "User", ErrorMessage = "Данный email уже кем-то занят")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        [MaxLength(30, ErrorMessage = "Длина пароля не должна превышать 30 символов")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Введите вашу дату рождения")]
        [DisplayFormat(DataFormatString = "{0:dd.mm.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Введите страну, в которой вы проживаете")]
        public Country Country { get; set; }
        public byte[] ProfilePicture { get; set; }
        [NotMapped]
        [MaxFileSize(8 * 1024 * 1024 * 100, ErrorMessage = "Максимальный размер изображения 100 МБ")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" }, ErrorMessage = "Допустимые расширения изображения: jpg, jpeg, png")]
        [MaxImageResolution(800, 800, ErrorMessage = "Максимальное разрешение изображения - 800x800")]
        public IFormFile? PfpFile { get; set; }
        public List<Rating>? MoviesRatings { get; set; } = null;
    }
}
