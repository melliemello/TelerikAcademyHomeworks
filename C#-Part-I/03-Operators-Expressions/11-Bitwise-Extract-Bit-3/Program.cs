/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
using System;*/
using System;

namespace _11_Bitwise_Extract_Bit_3
{
    class ExtractBit3
    {
        static void Main()
        {
            System.Console.Write("Enter a number to check:");
            int number = Convert.ToInt32(Console.ReadLine());
            int position = 3;
            int mask = 1 << position;
            int result = number & mask;
            result = result >> position;
            Console.WriteLine("The {0} bit is: {1}", position, result);
        }
    }
}
