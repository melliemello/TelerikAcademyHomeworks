//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
using System;
using System.Numerics;

namespace _08_Catalan_Numbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactorial = new BigInteger(1);
            BigInteger factorial = new BigInteger(1);
            BigInteger nPlus1Factorial = new BigInteger(1);

            for (int i = 1; i <= n*2; i++)
            {
                factorial *=(ulong) i;

                if (i == n+1)
                {
                    nPlus1Factorial = factorial;
                }

                if (i == n)
                {
                    nFactorial = factorial;
                }

            }
            Console.WriteLine("{0}", factorial / (nFactorial * nPlus1Factorial));


        }
    }
}
