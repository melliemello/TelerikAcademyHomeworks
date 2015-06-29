using System;

namespace _06.PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersToPrint = new int[3] { 1, 101, 1001 };
            foreach(int number in numbersToPrint)
            {
                Console.WriteLine(number);
            }            
        }
    }
}
