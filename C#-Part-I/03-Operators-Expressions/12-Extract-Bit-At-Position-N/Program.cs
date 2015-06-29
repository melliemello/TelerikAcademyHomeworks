/*Write an expression that extracts from given integer n the value of given bit at index p*/
using System;

namespace _11_Bitwise_Extract_Bit_3
{
    class ExtractBit3
    {
        static void Main()
        {
            System.Console.Write("Enter a number to check:");
            int number = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter the position to check:");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The {0} bit is: {1}", position, ExtractBitAt(position, number) );
            
        }

        static int ExtractBitAt(int position, int number) 
        {
            int mask = 1 << position;
            int result = number & mask;
            result = result >> position;
            return result;
        }
    }
}

