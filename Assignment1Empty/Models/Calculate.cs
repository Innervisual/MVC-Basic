namespace Assignment1Empty.Models
{
    public class Calculate
    {
        public static string[] CheckIfFever(int Temperature)
        {
            if (Temperature>39)
            {
                return new string[] { "Feverstatus", "You have fever!" };
            }
            else if (Temperature==0)
            {
                return new string[] { "You have not entered a valid temperature number!" };
            }
            else
            {
                return new string[] { "Feverstatus", "You do not have fever!" };
            }
        }

        public static string guessNumber(int guessedNumber, int generatedRandomNumber)
        {
            if (guessedNumber==generatedRandomNumber)
            {
                return "You won!";
            }
            else if (guessedNumber>100 || guessedNumber<=0)
            {
                return "Invalid input";
            }
            else if (guessedNumber<generatedRandomNumber)
            {
                return "To low";
            }
            else if (guessedNumber>generatedRandomNumber)
            {
                return "To high";
            }
            return "";
        }
    }
}
