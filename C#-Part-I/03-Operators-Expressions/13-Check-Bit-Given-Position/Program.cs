// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
using System;

namespace _13_Check_Bit_Given_Position
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("Enter a number to check:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the position you want to check:");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number at position {0} is 1: {1}", position, isOne(number, position).ToString());
        }

        static bool isOne(int number, int position)
        {
            int mask = 1 << position;
            int result = number & mask;
            return result >> position == 1 ? true : false;
        }
    }
}
