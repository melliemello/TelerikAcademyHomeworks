//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangleR(top=1, left=-1, width=6, height=2).
using System;

namespace _10_Inside_Circle_Outside_Rectangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Check if the Point is in the circle([1, 1], 1.5) and outside the rectangle (top=1, left=-1, width=6, height=2):{2}");
            Console.Write("Enter X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            bool result = isInCircle(x, y, 1, 1, 1.5) && isOutOfReactangle(x, y, 1, -1, 6, 2);
            Console.WriteLine(result);


        }

        static bool isInCircle(double x, double y, double circle_x, double circle_y, double radius)
        {
            return (Math.Pow(x - circle_x, 2) + Math.Pow(y - circle_y, 2) <= Math.Pow(radius, 2)) ? true : false;
        }

        static bool isOutOfReactangle(double x, double y, double rectTop, double rectLeft, double rectWidth, double rectHeight)
        {
            if (x < rectLeft || x > rectLeft + rectWidth
                || y > rectTop || y < rectTop - rectHeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
