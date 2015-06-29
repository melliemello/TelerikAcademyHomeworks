//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
using System;

namespace _14_Integer_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers, separated by ','");
            double[] arguments= Array.ConvertAll<string,double>(Console.ReadLine().Split(','), double.Parse);
            Console.WriteLine("Choose 1- Minimum number \n 2- Maximum number \n 3- Average number \n 4- Sum of sequence \n 5- Product of numbers");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Minimum number is:{0}", minNumber(arguments));
                    break;
                case 2:
                    Console.WriteLine("Maximum number is:{0}", maxNumber(arguments));
                    break;
                case 3:
                    Console.WriteLine("Average number is:{0}", Average(arguments));
                    break;
                case 4:
                    Console.WriteLine("Sum is:{0}", Sum(arguments));
                    break;
                case 5:
                    Console.WriteLine("Product number is:{0}", Product(arguments));
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
            
        }

        static double maxNumber(params double[] elements)
        {
            double max = elements[0];
            for (int i = 1; i < elements.Length; i++ )
            {
                if(elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static double minNumber(params double[] elements)
        {
            double min = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < min)
                {
                    min = elements[i];
                }
            }
            return min;
        }

        static double Average(params double[] elements)
        {
            double sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return sum / elements.Length;
        }

        static double Sum(params double[] elements)
        {
            double sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return sum;
        }

        static double Product(params double[] elements)
        {
            double product = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                product *= elements[i];
            }
            return product;
        }
    }
}
