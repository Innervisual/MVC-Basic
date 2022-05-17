using Assignment1Empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1Empty.Controllers
{
    public class Doctor : Controller
    {
        public IActionResult Temperature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(int Temp)
        {
            string result = Calculate.CheckIfFever(Temp);
            ViewBag.LinkableId=result;
            return View();
        }
    }
}
