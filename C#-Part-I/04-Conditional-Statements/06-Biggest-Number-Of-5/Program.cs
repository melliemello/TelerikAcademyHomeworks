//Write a program that finds the biggest of five numbers by using only five if statements.
using System;

namespace _06_Biggest_Number_Of_5
{
    class BiggestNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double d = Double.Parse(Console.ReadLine());
            double e = Double.Parse(Console.ReadLine());
            double max = a;

            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            if (e > max)
            {
                max = e;
            }
            Console.WriteLine("The biggest number is: {0}",max);
        }
    }
}
