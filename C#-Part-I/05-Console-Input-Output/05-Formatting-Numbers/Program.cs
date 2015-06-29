

using System;

namespace _05_Formatting_Numbers
{
    class NumberFormat
    {
        static void Main()
        {
            Console.WriteLine("Write 3 numbers- the first one should be integer, the rest- float numbers, separated by space:");
            string[] numbers = Console.ReadLine().Split(' ');
            int number1 = Int32.Parse(numbers[0]); 
            double number2 = Double.Parse(numbers[1]);
            double number3 = Double.Parse(numbers[2]);
            string binary = Convert.ToString(number1, 2).PadLeft(10,'0');
            Console.WriteLine("{0,10:X}|{1}|{2,10:F2}|{3,-10:F3}", number1, binary, number2, number3);
        }
    }
}
