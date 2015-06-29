//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
using System;

namespace _01_Exchange_If_Greater
{
    class ExchangeGreater
    {
        static void Main()
        {
            Console.Write("Enter nuber 1:");
            double maxNumber = Double.Parse(Console.ReadLine());
            Console.Write("Enter nuber 2:");
            double number = Double.Parse(Console.ReadLine());
            if (number > maxNumber)
            {
                double temp = number;
                number = maxNumber;
                maxNumber = temp;
            }
            Console.WriteLine("{0} {1}", number, maxNumber);
        }
    }
}
