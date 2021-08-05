using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Models.User;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService service)
        {
            _userService = service;
        }

        public IActionResult Index()
        {
            var users = _userService.GetUserList().Result;
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserRequestDto user)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            _userService.Create(user);
            return RedirectToAction("Index");
        }
    }
}