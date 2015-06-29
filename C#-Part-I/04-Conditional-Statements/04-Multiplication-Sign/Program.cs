//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
using System;


namespace _04_Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main()
        {
            int negativeCounter = 0;
            Console.WriteLine("Enter 3 numbers:");
            for (int i = 0; i < 3; i++ )
            {
                double number = Double.Parse(Console.ReadLine());
                if ( number < 0)
                {
                    negativeCounter++;
                }
                else if(number == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
            }
            Console.WriteLine("the result is with sign: {0}",negativeCounter % 2 == 0 ? "+" : "-" );
        }
    }
}
