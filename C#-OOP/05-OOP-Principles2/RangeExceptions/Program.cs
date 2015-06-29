using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class Program
    {
        static void Main()
        {
            int startInt = 0;
            int endInt = 100;
            DateTime startDate = DateTime.Parse("1.1.1980");
            DateTime endDate = DateTime.Parse("31.12.2013");
            bool IsFinished = false;

            Console.WriteLine("Enter an integer in the range [1..100]. Type END to end the test.");
            while (!IsFinished)
            {
                string input = Console.ReadLine();
                int number;
                if (input == "END")
                {
                    IsFinished = true;
                    break;
                }
                number = int.Parse(input);
                if (number < startInt || number > endInt)
                {
                    throw new InvalidRangeException<int>(startInt, endInt);
                }
            }

            Console.WriteLine("Enter date in the format 31.01.2014 in the range [1.1.1980 … 31.12.2013].Type END to end the test.");
            while (IsFinished)
            {
                string input = Console.ReadLine();
                DateTime date;
                if (input == "END")
                {
                    IsFinished = true;
                    break;
                }
                date = DateTime.Parse(input);
                if (date.CompareTo(startDate) < 0 || date.CompareTo(endDate) > 0)
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate);
                }
            }

            
        }
    }
}
