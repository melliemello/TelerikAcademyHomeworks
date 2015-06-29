using System;

namespace _03_Circle_Perimeter
{
    class CirclePerimeter
    {
        static void Main()
        {
            Console.Write( "Enter he radius of the circle:");
            double radius = Double.Parse(Console.ReadLine());
            Console.WriteLine("The area is {0:F2}, the perimeter is {1:F2}", Area(radius), Perimeter(radius));
        }

        static double Perimeter(double radius)
        {
            return Math.PI * radius * 2;
        }

        static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
