//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
using System;


namespace _06_Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 3 numbers- a,b and c for the quatratic equation ax^2 + bx + c = 0:");
            string[] numbers = Console.ReadLine().Split(' ');
            double a = Double.Parse(numbers[0]);
            double b = Double.Parse(numbers[1]);
            double c = Double.Parse(numbers[2]);
            

            double D = Math.Pow(b, 2) - (4 * a * c);
            if (D < 0){
                Console.WriteLine("Sorry, no real roots");
            }
            else if(D == 0)
            {
                double result = -1*b / 2*a;
                Console.WriteLine("The real root is {0}",result );
            }
            else if(D > 0)
            {
                double result1 = (-b + Math.Sqrt(D)) / (2 * a);
                double result2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Two real roots {0} and {1}", result1, result2);
            }
        }
    }
}
