/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/

using System;

namespace _14_Modify_Bit
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to check:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter bit position:");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value to set:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The binary representation is:" + Convert.ToString(number,2).PadLeft(16,'0'));
            if ((number & (1<<position) >> position) != value)
            {
                number = changeBit(number, position);
            }
            Console.WriteLine("Thenew number is:" + Convert.ToString(number, 2).PadLeft(16, '0'));
        }

        static int changeBit(int number, int position)
        {
            int mask = 1 << position;
            int result = number ^ mask;
            return result;
        }
    }
}
