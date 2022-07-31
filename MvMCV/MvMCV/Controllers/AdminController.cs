using Microsoft.AspNetCore.Mvc;

namespace MvMCV.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
