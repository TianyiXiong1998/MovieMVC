using Microsoft.AspNetCore.Mvc;

namespace MvMCV.Controllers
{
    public class MoiveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
