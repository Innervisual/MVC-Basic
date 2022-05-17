namespace Assignment1Empty.Models
{
    public class Calculate
    {
        public static string CheckIfFever(int Temperature)
        {
            if (Temperature>39)
            {
                return "You have fever!";
            }
            else if (Temperature==0)
            {
                return "You have not entered a valid temperature number!";
            }
            else
            {
                return "You do not have fever!";
            }
        }
    }
}
