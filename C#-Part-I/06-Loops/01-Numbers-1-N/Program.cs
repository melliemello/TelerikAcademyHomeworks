using System;

namespace _01_Numbers_1_N
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int limit =Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++ )
            {
                Console.Write(i + " ");
            }
        }
    }
}
