//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
using System;
//Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
namespace _05_Calculate_Factorial1
{
    class CalculateFactorial
    {
        static void Main()
        {
            Console.WriteLine("Enter N:");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X:");
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            double factorial = 1;
            for (int i = 1; i <= n; i++ )
            {
                
                factorial = i  * factorial;
                sum += factorial / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}", sum);

            
        }
    }
}
