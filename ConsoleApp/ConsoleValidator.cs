using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class ConsoleValidator
    {
        static void Main(string[] args)
        {
            //expected result should always be value of 5
            double expected = 5;
            //request user to enter value less than 5
            Console.WriteLine("Please enter a number less than 5");
            //validate user input
            if (!double.TryParse(Console.ReadLine(), out double input))
            {
                //invalid numerical value
                Console.WriteLine("Invalid number value received");
            }
            else
            {
                //determine what value is required to get to expected value of 5
                Console.WriteLine(string.Concat("The number required to get to 5 is ",  Subtract(expected, input)));
            }

            Console.Read();

        }

        public static double Subtract(double x, double y) {

            return (x - y);

        }
    }
}
