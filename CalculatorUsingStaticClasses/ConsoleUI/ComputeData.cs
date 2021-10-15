using System;
namespace ConsoleUI
{
    public class ComputeData
    {
        public static double DoOperation(double x, double y, string operationType)
        {
            double output = 0;

            if (operationType == "+")
            {
                output = x + y;
            }
            else if (operationType == "-")
            {
                output = x - y;
            }
            else if (operationType == "*")
            {
                output = x * y;
            }
            else if (operationType == "/")
            {
             output = x / y;
            }

            return output;
        }
    }
}
