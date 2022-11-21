namespace WebApplication3.Models
{
    public class FeverVM
    {
        public static string FeverCheck(int temp)
        {
            var message = "";
            if (temp <= 19)
            {
                message = "You are to coolt !";
            }
            else if (temp >= 19 && temp <= 25)
            {
                message = "You have i good temperatur !";
            }
            else if (temp >= 26)
            {
                if (temp <= 30)
                {
                    message = "You have Fever but is not to bad !";
                }
                else if (temp >= 31)
                {
                    message = "Go to the Doctor before you die !";
                }
            }
            else
            {
                message = "Check gose wrong";
            }
            return message;
        }
    }
}
