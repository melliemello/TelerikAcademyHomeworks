//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _16_Date_In_Bulgarian
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a date in format: day.month.year hour:minute:second :" );
            CultureInfo culture = new CultureInfo("bg-BG");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(culture.DateTimeFormat.GetDayName(date.AddMinutes(390).DayOfWeek)); 
            
        }
    }
}
