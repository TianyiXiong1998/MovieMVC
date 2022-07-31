using Microsoft.AspNetCore.Mvc;

namespace MvMCV.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
