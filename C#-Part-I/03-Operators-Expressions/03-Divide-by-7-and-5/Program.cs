using System;


namespace _03_Divide_by_7_and_5
{
    class DevideBy7and5
    {
        static void Main()
        {
            Console.WriteLine("Submit your number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number {0} be devided by 5 and 7" ,isDivisible(number) ? "can" : "can not");
        }
        static bool isDivisible(int number)
        {
            if (number % 5 != 0) return false;
            return true;
        }
    }
}
