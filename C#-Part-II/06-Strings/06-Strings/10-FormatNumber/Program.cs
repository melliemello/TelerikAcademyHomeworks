using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FormatNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to convert to  a decimal number, hexadecimal number, percentage and to scientific notation");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("To decimal:{0,15:d}", number);
            Console.WriteLine("To hex:{0,15:X}", number);
            Console.WriteLine("To percentage:{0,15:p}", number);
            Console.WriteLine("To scientific:{0,15:E}", number);
        }
    }
}
