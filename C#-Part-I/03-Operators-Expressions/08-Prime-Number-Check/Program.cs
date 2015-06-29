//Write an expression that checks if given positive integer number n (n = 100) is prime 
using System;

namespace _08_Prime_Number_Check
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter a number to check:");
            int number =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("The number {0}  {1}", number, isPrime(number)?"is prime": "is not prime");
        }
        static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            int boundary = Convert.ToInt32((Math.Sqrt(number)));
            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0) return false;
            }
            return true;

        }
    }
}
