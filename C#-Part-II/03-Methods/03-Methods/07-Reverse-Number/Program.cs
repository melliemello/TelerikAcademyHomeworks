//Write a method that reverses the digits of given decimal number.
using System;


namespace _07_Reverse_Number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write down a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The reversed number is:{0}", ReverseNumber(number));
        }

        static int ReverseNumber( int number)
        {
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return reversedNumber;
        }
    }
}
