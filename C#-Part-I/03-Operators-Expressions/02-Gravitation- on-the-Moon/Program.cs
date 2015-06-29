using System;

namespace _02_Gravitation__on_the_Moon
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Submit your weight on Earth: 00,00");
            double earthWeight = Convert.ToDouble(Console.ReadLine());
            double moonWeight = 0.17 * earthWeight;
            Console.WriteLine("Your weight is: " + moonWeight );
        }
    }
}
