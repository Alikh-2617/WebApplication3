namespace WebApplication3.Models
{
    public class GameModel
    {
        public static int counter = 0;
        public static int genericNumber = 0;

        public static string Game(int input)
        {
            string response =" ";
            if(counter == 0)
            {
                genericNumber = GenericNumber();

            }
            else
            {
                counter++;
                if (input == genericNumber)
                {
                    response = "Congratulating you Wine !!";
                    counter = 0;
                }
                else
                {
                    response = "Number was not Correct ";
                }
            }
            return response;
        }

        public static int GenericNumber()
        {
            Random random = new Random();
            int number = random.Next(0, 100);
            return number;
        }

    }
}
