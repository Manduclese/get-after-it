using System;

namespace ConsoleUI
{




    class Program
    {
        static void Main(string[] args)
        {
            UserMessages.AppWelcomeMessage();

            double x = GetInformation.GetDouble("Please enter your first number: ");

            string operationType = GetInformation.GetOperationType("Please enter an operation type(+,-,*,/): ");

            double y = GetInformation.GetDouble("Please enter your second number: ");

            double result = ComputeData.DoOperation(x, y, operationType);

            UserMessages.PrintResult(x, y, operationType, result);

            Console.ReadLine();
        }
    }
}
