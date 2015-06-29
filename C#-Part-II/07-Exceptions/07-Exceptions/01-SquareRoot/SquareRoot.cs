using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Exceptions
{
    class Root
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input number to find its square root: ");
            string input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);
                double squareRoot = SquareRoot(number);
                Console.WriteLine("Square root of {0} is {1}", number, squareRoot);
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("That's all, folks");
            }
        }

        public static double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Round(Math.Sqrt(value), 2);
        }
    }
}
