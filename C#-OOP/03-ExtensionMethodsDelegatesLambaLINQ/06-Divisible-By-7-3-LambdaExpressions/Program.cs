using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Divisible_By_7_3_LambdaExpressions
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,11,14,16,17,19,21,42};
            int[] result = numbers.Where(number => number % 3==0 && number % 7 == 0).ToArray();

            var resultQueries = from number in numbers
                                  where number % 3 == 0 && number % 7 == 0
                                  select number;
            //Original array:
            Console.WriteLine("Original array");
            foreach(int number in numbers)
            {
                Console.Write("{0,3}", number);
            }

            //Result with LINQ methods
            Console.WriteLine("Result using methods");
            foreach(int number in result)
            {
                Console.Write("{0,3}", number);
            }
            Console.WriteLine();

            //Result with queries
            Console.WriteLine("Result using Queries");
            foreach(int number in resultQueries)
            {
                Console.Write("{0,3}", number);                
            }
            Console.WriteLine();
        }
    }
}
