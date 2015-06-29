using System;


namespace _01
{
    class Program
    {
        static void Main()
        {
            long a = Int64.Parse(Console.ReadLine());
            long b = Int64.Parse(Console.ReadLine());
            long c = Int64.Parse(Console.ReadLine());
            long[] numbers = new long[] { a, b, c };
            long max = a;
            long min = a;
            double sum = 0;

            for (int i = 0; i < 3; i++ )
            {
                sum += numbers[i];
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            double m = (sum / 3);
            m = Math.Round(m,3);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F3}",m);

        }
    }
}
