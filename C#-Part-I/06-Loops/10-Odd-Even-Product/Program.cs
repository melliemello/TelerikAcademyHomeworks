using System;

namespace _10_Odd_Even_Product
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("check if the sum of the odd numbers is equal to the sum of the even ones");
            Console.WriteLine("enter integers, separated by space:");
            string[] numbers = Console.ReadLine().Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            int len = numbers.Length;
            for (int i = 0; i < len; i++ )
            {
                if ((i+1) % 2 != 0)
                {
                    oddProduct *= int.Parse(numbers[i]);                    
                }
                else
                {
                    evenProduct *= int.Parse(numbers[i]);
                }
            }

            Console.WriteLine("{0}", evenProduct == oddProduct ? "yes" : "no");
        }
    }
}
