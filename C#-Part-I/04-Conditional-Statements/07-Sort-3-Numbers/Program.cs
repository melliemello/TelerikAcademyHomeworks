//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

namespace _07_Sort_3_Numbers
{
    class Sort
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());

            if(a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else 
                {
                    if (a > c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                }
            }
            else 
            {
                if (b < c)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else
                {
                    if (c > a)
                    {
                        Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", b, a, c);
                    }
                }
            }

        }
    }
}
