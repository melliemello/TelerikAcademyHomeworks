//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;


namespace _02_Binary_To_Decimal
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Enter a binary number to convert to decimal:");
            string binary = Console.ReadLine();
            Console.WriteLine(ToDecimal(binary));
        }

        static int ToDecimal(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++ )
            {
                sum += (number[i] - 48) * (int) Math.Pow(2, number.Length - i - 1);
            }
            return sum;           
        }
    }
}
