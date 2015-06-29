//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
using System;


namespace _13_Find_All_Prime_Numbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write down the upper limit for the prime numbers:");
            int limit = int.Parse(Console.ReadLine()) + 1;
            bool[] numbers = new bool[limit];

            //Initialize the array

            for (int i = 1; i < limit; i++)
            {
                numbers[i] = true;
            }

            for (int i = 2; i < limit; i++)
            {
                if (numbers[i] != false)
                {
                    Console.Write(i);
                    for (int j = i * i; j < limit; j += i)
                    {
                        numbers[j] = false;
                    }
                }

            }
        }
    }
}
