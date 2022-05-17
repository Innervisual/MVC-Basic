using Assignment1Empty.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1Empty.Controllers
{
    public class GuessingGame : Controller
    {

        [HttpGet]
        public IActionResult guessingGameView()
        {
            int generatedNumber = GenerateNumber.GenerateRandomNumber();
            HttpContext.Session.SetInt32("RandomNumber", generatedNumber);
            return View();
        }

        [HttpPost]
        public IActionResult guessingGameView(int guessedNumber)
        {
            int generatedRandomNumber = (int)HttpContext.Session.GetInt32("RandomNumber");
            if (guessedNumber==generatedRandomNumber)
            {
                return RedirectToAction("guessingGamePost");
            }

            else
            {
                if (guessedNumber>100 || guessedNumber<=0)
                {
                    ViewBag.LinkableId="Invalid input";
                }

                else if (guessedNumber<generatedRandomNumber)
                {
                    ViewBag.LinkableId="To low";
                }

                else if (guessedNumber>generatedRandomNumber)
                {
                    ViewBag.LinkableId="To high";
                }

                return View();
            }
        }

        public IActionResult guessingGamePost()
        {
            return View();
        }
    }
}
