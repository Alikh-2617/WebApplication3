namespace WebApplication3.Data
{
    public class Check
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
