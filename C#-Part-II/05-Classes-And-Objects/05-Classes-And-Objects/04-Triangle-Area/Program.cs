using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triangle_Area
{
    class Program
    {
        static void Main()
        {
            double a = 5;
            double b = 6;
            double c = 3;

            double d = 5;
            double hd = 7;

            double e = 4;
            double f = 6;
            double angle = 35;

            Console.WriteLine("Area of triangle with side a {0}, side b {1}, side c {2} is:{3}",a,b,c,AreaBySides(a,b,c));
            Console.WriteLine("Area of triangle with side a {0}, side height {1} is:{2}", d, hd, AreaBySideHeight(d,hd));
            Console.WriteLine("Area of triangle with side a {0}, side b {1}, and angle {2} is:{3}", e,f,angle, AreaBySidesAndAngle(e,f,angle));

            
        }
        static double AreaBySides(double a, double b, double c)
        {
            double semiP = (a + b + c) / 2;
            return Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));            
        }

        static double AreaBySideHeight(double a, double hA)
        {
            return (a * hA) / 2;
        }

        static double AreaBySidesAndAngle(double a, double b, double angle)
        {
            return (Math.Sin(angle*(Math.PI/180)) * a * b) / 2;
        }
    }
}
