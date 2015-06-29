//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
using System;

namespace _06_CalculateFactorials2
{
    class CalculateFactorials
    {
        static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:");
            int k = int.Parse(Console.ReadLine());
            int kFactorial = 0;
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

                if (i == k) 
                {
                    kFactorial = factorial;
                }
   
            }
            Console.WriteLine("{0}", factorial / kFactorial);


        }
    }
}
