//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
using System;


namespace _03_Min_Max_Average_Sum
{
    class MinMaxAverage
    {
        static void Main()
        {
            long sum = 0;
            long counter = 0;
            long max = long.MinValue;
            long min = long.MaxValue;
            long number;
            Console.WriteLine("Enter a number:");
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                number = Int64.Parse(Console.ReadLine());
                if (number < min )
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                sum += number;
                counter++;
            }
            Console.WriteLine("Max is {0}", max);
            Console.WriteLine("Min is {0}", min);
            Console.WriteLine("Average is {0}", sum / counter);
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
