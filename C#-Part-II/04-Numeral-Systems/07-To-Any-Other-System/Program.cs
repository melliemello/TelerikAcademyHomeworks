using System;
using System.Text;


namespace _07_To_Any_Other_System
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a number to covert: ");
            string number = Console.ReadLine();
            Console.WriteLine("Write the base of the number: ");
            int baseX = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the destination base of the number: ");
            int baseY = int.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToOther( ToDecimal(number, baseX), baseY));
        }

        static int ToDecimal(string number, int baseX)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++ )
            {
                sum += ToDecimalDigit(Char.ToUpper(number[i])) * (int) Math.Pow(baseX, number.Length - i - 1);
            }
            return sum;           
        }

        static string DecimalToOther(int number, int baseY)
        {
            StringBuilder result = new StringBuilder();
            while(number > 0)
            {
                result.Insert(0,number % baseY ) ;
                number /= baseY;
            }
            return result.ToString();
        }

        static int ToDecimalDigit(char digit)
        {
            int result = 0;
            if (digit > 47 && digit < 58)
            {
                return result = (int)digit - 48;
            }
            else if (digit > 64 && digit < 71)
            {
                result = digit - 55;
                return result;
            }
            else
            {
                Console.WriteLine("Enter a valid number");
                return -1;
            }
        }
    }
}
