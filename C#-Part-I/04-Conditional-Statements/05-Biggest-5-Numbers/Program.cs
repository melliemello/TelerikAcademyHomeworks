using System;

namespace _05_Biggest_5_Numbers
{
    class BiggestNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("The biggest number is:{0}", max);

        }
    }
}
