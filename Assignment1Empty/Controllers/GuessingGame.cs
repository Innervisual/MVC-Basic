using Assignment1Empty.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1Empty.Controllers
{
    public class GuessingGame : Controller
    {


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
            string result = Calculate.guessNumber(guessedNumber, generatedRandomNumber);
            ViewBag.LinkableId=result;
            if (result == "You won!")
            {
                int generatedNumber = GenerateNumber.GenerateRandomNumber();
                HttpContext.Session.SetInt32("RandomNumber", generatedNumber);
            }
            return View();

        }

        public IActionResult guessingGamePost()
        {
            return View();
        }
    }
}
