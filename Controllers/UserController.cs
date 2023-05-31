using IMS.Data;
using IMS.Models;
using IMS.Models.Interfaces;
using IMS.Models.Repositories;
using IMS.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers
{
    public class UserController : Controller
    {
        private readonly string connectionString;
        private readonly ILogger<MoviesController> logger;
        public UserController(ILogger<MoviesController> logger)
        {
            this.logger = logger;
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            connectionString = configuration.GetConnectionString("Default");
        }

        public IActionResult ChangePfp(int userId, string userUrlId)
        {
            using (var db = new ApplicationDbContext(connectionString))
            {
                try
                {
                    IUsers users = new UsersRepository(db);

                    byte[]? imageData = null;
                    UserViewModel userVM = new UserViewModel();
                    User? user = users.FindSetByCondition(u => u.Id == userId || u.UserUrlId == userUrlId).FirstOrDefault();
                    using (var stream = new BinaryReader(userVM.UserPfpFile.OpenReadStream()))
                    {
                        imageData = stream.ReadBytes((int)userVM.UserPfpFile.Length);
                    }
                    user.ProfilePicture = imageData;
                    userVM.User = user;
                    users.Update(user);
                    users.Save();

                    return RedirectToAction("Profile", new { userId, userUrlId });
                }
                catch(Exception e)
                {
                    logger.LogError(e.Message);
                    return View();
                }
            }
        }

        [Route("User/Profile")]
        public IActionResult Profile(int userId, string userUrlId)
        {
            using (var db = new ApplicationDbContext(connectionString))
            {
                try
                {
                    IUsers users = new UsersRepository(db);

                    byte[]? imageData = null;
                    UserViewModel userVM = new UserViewModel();
                    User? user = users.FindSetByCondition(u => u.Id == userId || u.UserUrlId == userUrlId).FirstOrDefault();

                    using (var stream = new BinaryReader(userVM.UserPfpFile.OpenReadStream()))
                    {
                        imageData = stream.ReadBytes((int)userVM.UserPfpFile.Length);
                    }
                    user.ProfilePicture = imageData;
                    userVM.User = user;

                    return View(userVM);
                }
                catch(Exception e)
                {
                    logger.LogError(e.Message);
                    return View();
                }
            }
        }

        [Route("User/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("User/Login")]
        public IActionResult Login(string nickname, string password, string email)
        {
            using (var db = new ApplicationDbContext(connectionString))
            {
                IUsers users = new UsersRepository(db);
                User? user = users.FindSetByCondition(u => u.NickName == nickname && u.Password == password && u.Email == email).FirstOrDefault();
                if (user != null)
                {
                    return RedirectToAction("Profile", new { user.Id, user.UserUrlId });
                }
                else
                {
                    ModelState.AddModelError("User not found", "Такого профиля не существует. Попробуйте зарегистрировать новый профиль.");
                    logger.LogWarning($"User with nickname {nickname} was not found");
                    return View();
                }
            }
        }

        [Route("User/Register")]
        public IActionResult Register()
        {
            using (var db = new ApplicationDbContext(connectionString))
            {
                ICountries countries = new CountriesRepository(db);
                UserViewModel userViewModel = new UserViewModel();
                userViewModel.Countries = countries.GetAll().ToList();
                return View(userViewModel);
            }
        }

        [HttpPost]
        [Route("User/Register")]
        public IActionResult Register(string nickname, string name, string surname, string password, string email, string birthdate, string country, byte[] pfp)
        {
            using (var db = new ApplicationDbContext(connectionString))
            {
                IUsers users = new UsersRepository(db);
                ICountries countries = new CountriesRepository(db);

                byte[]? imageData = null;
                UserViewModel userVM = new UserViewModel();
                User user = new User
                {
                    NickName = nickname,
                    Name = name,
                    Surname = surname,
                    Password = password,
                    Email = email,
                    BirthDate = DateOnly.Parse(birthdate),
                    Country = countries.FindSetByCondition(c => c.Name == country).FirstOrDefault()
                };

                using (var stream = new BinaryReader(userVM.UserPfpFile.OpenReadStream()))
                {
                    imageData = stream.ReadBytes((int)userVM.UserPfpFile.Length);
                }
                user.ProfilePicture = imageData;

                userVM.User = user;
                users.Create(user);
                users.Save();

                return View(userVM);
            }
        }
    }
}