using System;
using System.Text;

namespace _10_Print_Fibonacci
{
    class FibonacciSeries
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the serie:");
            int boundary = Int32.Parse(Console.ReadLine());
            int prev = 0;
            int next = 1;
            StringBuilder serie = new StringBuilder();
            serie.Append(prev);

            if (boundary > 1 ) 
            {
                for (int i = 1; i < boundary; i++ )
                {
                    serie.Append(", " + next);
                    int temp = next;
                    
                    next += prev;
                    prev = temp;
                }
            }

            Console.WriteLine(serie);
        }
    }
}
