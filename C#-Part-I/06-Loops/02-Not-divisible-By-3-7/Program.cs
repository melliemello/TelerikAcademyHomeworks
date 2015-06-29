using System;

namespace _02_Not_divisible_By_3_7
{
    class NotDivisibleBy3and7
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int limit =Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++ )
            {
                if(i %3 != 0 && i % 7 !=0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
