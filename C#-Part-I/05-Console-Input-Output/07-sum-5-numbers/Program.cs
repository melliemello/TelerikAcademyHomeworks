//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum
using System;

namespace SumNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write 5 numbers to sum:");
            string[] stringNumber = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < 5; i++ )
            {
                sum += Double.Parse(stringNumber[i]);
            }
            Console.WriteLine("The sum is:{0}", sum);
        }
    }
}
