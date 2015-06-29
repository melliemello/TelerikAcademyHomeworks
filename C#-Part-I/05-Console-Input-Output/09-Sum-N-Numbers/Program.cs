using System;

namespace _09_Sum_N_Numbers
{
    class SumNumbers
    {
        static void Main()
        {
            Console.WriteLine("How many numbers you want to sum?");
            int boundary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            int i = 0;
            double sum = 0;
            do
            {
                sum += Double.Parse(Console.ReadLine());
                i++;
            } while (i < boundary);
            Console.WriteLine("The sum is:{0}", sum );
        }              
    }
 }
