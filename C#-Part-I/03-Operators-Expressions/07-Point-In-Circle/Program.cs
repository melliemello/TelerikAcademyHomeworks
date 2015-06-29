//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
using System;

namespace _07_Point_In_Circle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the the X coord for the point:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the the Y coord for the point:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the the X coord for the point:");
            double circle_x = 0;
            double circle_y = 0;
            double radius = 2;
            Console.WriteLine("The point {0} in the circle [(0,0)2]", isInCircle(x, y, circle_x, circle_y, radius)?"is":"is not");
        }

        static bool isInCircle(double x, double y, double circle_x, double circle_y, double radius)
        {
            return (Math.Pow(x - circle_x,2) + Math.Pow(y - circle_y,2) <= Math.Pow(radius,2)) ? true : false;
        }
    }
}
