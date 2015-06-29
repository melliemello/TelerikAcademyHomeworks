using System;
using System.Collections.Generic;


namespace _04_Decimal_To_Hexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a decimal number to convert to hexadecimal");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ToHexadecimal(number));
        }

        static string ToHexadecimal( int number)
        {
            List<string> hexNumber = new List<string>();
            while(number > 0)
            {
                string remainder = ToHexadecimalDigit(number % 16);
                number =  (int) Math.Floor((double)(number / 16));
                hexNumber.Add(remainder);
            }

            hexNumber.Reverse();
            return String.Join("",hexNumber);
        }

        static string ToHexadecimalDigit(int number)
        {
            string result = "";
            if(number <10)
            {
                return number.ToString();
            }
            else
            {
                switch (number)
                {
                    case 10:
                        result = "A";
                        break;
                    case 11:
                        result = "B";
                        break;
                    case 12:
                        result = "C";
                        break;
                    case 13:
                        result = "D";
                        break;
                    case 14:
                        result = "E";
                        break;
                    case 15:
                        result = "F";
                        break;
                    case 16:
                        result = "G";
                        break;
                }
                return result;
            }
            
        }
    }
}
