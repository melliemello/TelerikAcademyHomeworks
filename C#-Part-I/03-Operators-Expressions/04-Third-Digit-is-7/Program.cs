using System;

namespace _04_Third_Digit_is_7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Check if the third digit of the number is 7:");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The third digit {0} 7", isThirdDigit7(number) ?"is":"is not");
        }

        static bool isThirdDigit7(int number)
        {
            if ((number / 100) % 10 != 7) return false;
            return true;
        }
    }
}
