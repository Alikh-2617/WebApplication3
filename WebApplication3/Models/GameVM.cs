namespace WebApplication3.Models
{
    public class GameVM
    {
        public static int counter = 0;

        public static string Game(int input, int genericNumber)
        {
            counter++;
            if (input > genericNumber)
            {
                return "the number is lower ";
            }
            else if (input < genericNumber)
            {
                return "the number is higher ";
            }
            else if (input == genericNumber)
            {
                counter = -1;
                return "Congratulating you Wine !!";
            }

            return "the number is between 0 to 100 . ";
        }

        public static int GenericNumber()
        {
            Random random = new Random();
            return random.Next(0, 100); ;
        }

    }
}
