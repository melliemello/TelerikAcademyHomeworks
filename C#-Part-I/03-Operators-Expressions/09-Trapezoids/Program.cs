//Write an expression that calculates trapezoid's area by given sides a and b and height h
using System;

namespace _09_Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Enter Side A in format 00,00:");
            double a =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Side B in format 00,00:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height H in format 00,00:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area is: {0}",GetTrapezoidArea(a, b, h) );
        }

        static double GetTrapezoidArea(double a, double b, double h)
        {
	        return ((a + b)/2)*h;	
        }
    }
}
