//English digit
using System;

namespace _03_English_Digit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Last digit is:{0}", LastDigit(number));
        }

        static string LastDigit(int number)
        {
            int lastDigit = number % 10;
            string stringDigit = "";
            switch (lastDigit)
            {
                case 0:
                    stringDigit = "zero";
                    break;
                case 1:
                    stringDigit = "one";
                    break;
                case 2:
                    stringDigit = "two";
                    break;
                case 3:
                    stringDigit = "three";
                    break;
                case 4:
                    stringDigit = "four";
                    break;
                case 5:
                    stringDigit = "five";
                    break;
                case 6:
                    stringDigit = "six";
                    break;
                case 7:
                    stringDigit = "seven";
                    break;
                case 8:
                    stringDigit = "eight";
                    break;
                case 9:
                    stringDigit = "nine";
                    break;
                default:
                    stringDigit = "not a valid number";
                    break;
            }
            return stringDigit;
        }
    }
}
