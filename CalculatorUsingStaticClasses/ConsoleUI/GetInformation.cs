using System;
namespace ConsoleUI
{
    public class GetInformation
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }


        public static double GetDouble(string message)
        {
            bool isDouble = false;
            double output = 0;
            string doubleString = "";

            
            doubleString = GetInformation.GetString(message);
            isDouble = double.TryParse(doubleString, out output);

            while (isDouble == false)
            {
                Console.Clear();
                doubleString = GetInformation.GetString("That was not a correct number. Please try again. ");
                isDouble = double.TryParse(doubleString, out output);
            }

            return output;

        }


        public static string GetOperationType(string message)
        {
            bool keepGoing = true;
            string output = "";

            Console.Clear();
            Console.Write(message);
            string input = Console.ReadLine();

            while (keepGoing == true)
            {
                if (input == "+" || input == "-" || input == "/" || input == "*")
                {
                    output = input;
                    keepGoing = false;
                    
                }
                else
                {
                    Console.Clear();
                    Console.Write("Please enter a valid operation type(+,-,*,/): ");
                    input = Console.ReadLine();
                }
            }

            return output;
        }
    }
}
