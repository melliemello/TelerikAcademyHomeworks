//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
using System;

namespace _09_MatrixNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++ )
            {
                int number = i;
                for (int j = 0; j < n; j++ )
                {
                    Console.Write(number);
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
