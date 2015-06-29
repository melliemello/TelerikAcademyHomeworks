using System;
using System.Text;

namespace _11_Numbers_in_Interval
{
    class NumbersInterval
    {
        static void Main()
        {
            Console.WriteLine("Enter the start boundary:");
            int start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end boundary:");
            int end = Int32.Parse(Console.ReadLine());
            StringBuilder divisibleBy5 = new StringBuilder();
            int counter = 0;
            for (int number = start; number <= end; number++ )
            {
                if (number % 5 == 0 && number != start)
                {
                    counter++;
                    divisibleBy5.Append(", " + number);
                }

                if (number % 5 == 0 && number == start)
                {
                    counter++;
                    divisibleBy5.Append(number);
                }
            }

            Console.WriteLine("{0} numbers: {1}", counter, divisibleBy5);
 
        }
    }
}
