using Microsoft.AspNetCore.Mvc;
using SIMSWebApp.Models;
using SIMSWebApp.Services;

namespace SIMSWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserService _userService;
        public LoginController(UserService userService)
        {
            _userService = userService; 
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // khong co loi xay ra
                string username = model.Username.Trim();
                string password = model.Password.Trim();
                var user = await _userService.LoginUserAsync(username, password);
                if (user == null)
                {
                    // thong bao thong tin sai tai khoan ra ngoai view
                    ViewData["InvalidAccount"] = "Your account invalid";
                    return View(model);
                }
                return RedirectToAction("Index","Dashboard");
            }
            return View(model);
        }
    }
}
