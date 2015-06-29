using System;

namespace _13_ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double eps = 0.000001;
            Console.WriteLine("Please enter 2 values to compare:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            bool isEqual = Math.Abs(a - b) < eps;
            if (isEqual)
            {
                Console.WriteLine("The values are equal");
            }
            else
            {
                Console.WriteLine("The values are different");
            }
        }
    }


}
