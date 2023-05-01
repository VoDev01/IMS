using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
