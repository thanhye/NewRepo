using Microsoft.AspNetCore.Mvc;

namespace SIMSWebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
