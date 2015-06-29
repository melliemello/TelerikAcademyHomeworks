using System;


namespace _04_Rectangle_Area
{
    class Rectangle_Area
    {
        static void Main()
        {
            Console.WriteLine("Submit the height and width of the rectangle on 2 separate lines:");
            double height = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area is:{0}, the perimeter is{1}", findArea(height, width), findPerimeter(height, width));

        }
        static double findArea(double height, double width)
        {
            return height * width;
        }
        static double findPerimeter(double height, double width)
        {
            return (height + width) * 2;
        }
    }
}
