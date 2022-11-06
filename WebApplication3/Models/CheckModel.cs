namespace WebApplication3.Models
{
    public class CheckModel
    {
        public static string CheckAge(int age)
        {
            if (age >= 18)
            {
                return "You are old enough to vote !";
            }
            else
            {
                return "You are NOT old enough to vote";
            }
        }
    }
}
