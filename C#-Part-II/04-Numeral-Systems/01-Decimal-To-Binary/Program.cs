//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;


namespace _01_Decimal_To_Binary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Enter a decimal number to convert to binary");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}",ToBinary(number).PadLeft(32, '0'));

        }

        static string ToBinary(int number)
        {
            List<string> binary = new List<string>();
            while (number > 0)
            {
                binary.Add((number % 2).ToString());
                double result  = number / 2;
                number = (int)Math.Floor(result);

            }
            binary.Reverse();
            return String.Join("",binary);
        }
    }
}
