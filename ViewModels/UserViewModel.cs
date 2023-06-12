using CustomValidationAttributes;
using IMS.Models;

namespace IMS.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        /*[MaxFileSize(8 * 1024 * 1024 * 100, ErrorMessage = "Максимальный размер изображения 100 МБ")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg" }, ErrorMessage = "Допустимые расширения изображения: jpg и jpeg")]
        [MaxImageResolution(800, 800, ErrorMessage = "Максимальное разрешение изображения - 800x800")]*/
        //public IFormFile UserPfpFile { get; set; }
        public ICollection<Country> Countries { get; set; }
    }
}
