using System;

namespace _01_Odd_or_Even
{
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            string result;
            if (number % 2 == 0)
            {
                result = "The number is even";
            }
            else {
                result = "The number is odd";
            }
            Console.WriteLine(result);

        }
    }
}
