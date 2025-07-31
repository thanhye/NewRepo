using Microsoft.AspNetCore.Mvc;

namespace SIMSWebApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
