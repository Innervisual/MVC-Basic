using Microsoft.AspNetCore.Mvc;

namespace Assignment1Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Test()
        {
            return View();

        }
        public IActionResult About()
        {
            return View();

        }
        public IActionResult Contacts()
        {
            return View();

        }
        public IActionResult Projects()
        {
            return View();
        }
    }
}
