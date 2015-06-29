using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Workdays
{
    class Program
    {
        static void Main()
        {
            List<DateTime> holidays = new List<DateTime>();
                               holidays.Add(new DateTime(2015,3,3));
                               holidays.Add(new DateTime(2015,11,1));
                               holidays.Add(new DateTime(2015,12,24));
                               holidays.Add(new DateTime(2015,12,25));
                               holidays.Add(new DateTime(2015,12,31));
            
            
                             
            Console.WriteLine("Enter start date in format yyyy-MM-dd:");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter end date in format yyyy-MM-dd:");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

            int workdays = 0;
            while(startDate <= endDate)
            {
                if((int)startDate.DayOfWeek != 6 && (int)startDate.DayOfWeek !=0 && !holidays.Contains(startDate) )
                {
                    workdays++;
                }
                startDate = startDate.AddDays(1);
            }

            Console.WriteLine("Number of working days: {0}", workdays);
         }
    }
}
