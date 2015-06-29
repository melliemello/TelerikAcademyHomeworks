using System;

namespace _15.CalculateAge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your birthdate in this format: DD/MM/YYYY");
            string inputDate = Console.ReadLine();
            int currentAge = CalculateAge(inputDate, DateTime.Now);
            int ageAfter10Years = CalculateAge(inputDate, DateTime.Now.AddYears(10));
            Console.WriteLine("Your current age is: " + currentAge);
            Console.WriteLine("In 10 years you will be at age of: " + ageAfter10Years);
        }
        static int CalculateAge(string inputdate, DateTime year)
        {
            DateTime birthdate = Convert.ToDateTime(inputdate);
            TimeSpan span = year - birthdate;
            int days = Convert.ToInt32(span.Days) / 365;
            return days;
        }
    }
}
