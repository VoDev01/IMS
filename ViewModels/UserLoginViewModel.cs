using System.ComponentModel.DataAnnotations;

namespace IMS.ViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Введите логин")]
        [MaxLength(20, ErrorMessage = "Длина логина не должна превышать 20 символов")]
        [MinLength(5, ErrorMessage = "Длина логина не должна быть менее 5 символов")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Введите ваш email")]
        [MaxLength(35, ErrorMessage = "Длина email не должна превышать 35 символов")]
        [EmailAddress(ErrorMessage = "Не соответсвует email адресу")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        [MaxLength(30, ErrorMessage = "Длина пароля не должна превышать 30 символов")]
        public string Password { get; set; }
        public int? MovieId { get; set; } = null;
    }
}
