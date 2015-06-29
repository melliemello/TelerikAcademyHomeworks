//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English)

using System;

namespace _08_Digit_As_Number
{
    class DigitAsNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a digit to spell:");
            string a = Console.ReadLine();
            string result;

            switch(a)
            {
                case "1":
                    result = "One";
                    break;
                case "2":
                    result = "Two";
                    break;
                case "3":
                    result = "Three";
                    break;
                case "4":
                    result = "Four";
                    break;
                case "5":
                    result = "Five";
                    break;
                case "6":
                    result = "Six";
                    break;
                case "7":
                    result = "Seven";
                    break;
                case "8":
                    result = "Eight";
                    break;
                case "9":
                    result = "Nine";
                    break;
                case "0":
                    result = "Zero";
                    break;
                default:
                    result = "Not a digit";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
