//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

namespace _01_Sum_Numbers
{
    class SumNumbers
    {
        static void Main()
        {
            Console.Write("Enter 3 numbers separated by space:");
            string[] numbers = Console.ReadLine().Split(' ');
            Console.WriteLine("The sum is:{0}:", Int32.Parse(numbers[0]) + Int32.Parse(numbers[1]) + Int32.Parse(numbers[2]));
        }
    }
}
