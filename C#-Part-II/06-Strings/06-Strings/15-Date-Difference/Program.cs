using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace _15_Date_Difference
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write down a date in the format 27.02.2014:");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Write down a second date in the format 27.02.2014:");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            TimeSpan difference = secondDate - firstDate;
            Console.WriteLine("{0} days", difference.TotalDays);


        }
    }
}
