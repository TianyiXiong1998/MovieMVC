using Microsoft.AspNetCore.Mvc;

namespace MvMCV.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
