//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
using System;

namespace _08_Print_Numbers
{
    class PrintNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write a number/boundary:");
            int boundary = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= boundary; i++ )
            {
                Console.WriteLine(i);
            }
        }
    }
}
