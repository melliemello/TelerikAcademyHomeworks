using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class Program
    {
        static void Main()
        {
            PrintSequenceFrom(2, 1000);
        }

        static void PrintSequenceFrom(int number, int length)
        {
            int i = 0;
            while (i < length)
            {
                Console.Write(number.ToString() + ", ");
                number = (Math.Abs(number) + 1) * number / Math.Abs(number) * -1;
                i++;
            }
        }
    }
}
