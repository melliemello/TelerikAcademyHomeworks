//Write a program that reads a year from the console and checks whether it is a leap one
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Leap_Year_Check
{
    class IsLeap
    {
        static void Main()
        {
            Console.WriteLine("Write an year to check:");
            bool result = DateTime.IsLeapYear(int.Parse(Console.ReadLine()));
            Console.WriteLine("The year is leap: " + result);
              
        }
    }
}
