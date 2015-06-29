//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
using System;

namespace _04_Number_Comparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Write two numbers separated by space:");
            string[] numbers = Console.ReadLine().Split(' ');
            double number1 = Double.Parse(numbers[0]);
            double number2 = Double.Parse(numbers[1]);
            double maxNumber = (Math.Abs(number1 + number2) + Math.Abs(number1 - number2)) / 2;
            Console.WriteLine("The greater number is:{0}", maxNumber);
        }
    }
}
