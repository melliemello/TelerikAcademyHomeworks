//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Integers
{
    class Sum
    {
        static void Main()
        {
            Console.WriteLine("enter a sequence of numbers, separated by space:");
            int[] numbers = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("The sum is:{0}", SumNumbers(numbers));
            
        }

        static int SumNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++ )
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
