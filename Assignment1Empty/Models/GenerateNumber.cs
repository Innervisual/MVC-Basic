using System;

namespace Assignment1Empty.Models
{
    public class GenerateNumber
    {
        public static int GenerateRandomNumber()
        {
            Random rnd = new Random();
            int randomInt = rnd.Next(1, 101);  // creates a number between 1 and 100
            return randomInt;
        }
    }
}
