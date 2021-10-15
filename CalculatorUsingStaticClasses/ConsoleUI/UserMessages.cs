using System;
namespace ConsoleUI
{
    public class UserMessages
    {
        public static void AppWelcomeMessage()
        {
            string firstName = GetInformation.GetString("What is your first name? ");

            Console.Clear();

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning, { firstName }, welcome to my calculation app!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good afternoon, { firstName }, welcome to my calculation app!");
            }
            else
            {
                Console.WriteLine($"Good evening, { firstName }, welcome to my calculation app!");
            }
            
        }

        public static void PrintResult(double x, double y, string operationType, double result)
        {
            Console.Clear();
            Console.WriteLine($"The result of { x } { operationType } { y } is { result }");
            Console.WriteLine();
            Console.WriteLine($"Thank you for using my calculation app!");
        }
    }
}
