using IMS.Models;

namespace IMS.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IFormFile UserPfpFile { get; set; }
        public ICollection<Country> Countries { get; set; }
    }
}
