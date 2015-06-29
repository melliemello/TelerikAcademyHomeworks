using System;


namespace _11_Print_Random_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers you want to print:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lower boundary of the range:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the highest boundary of the range:");
            int max = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();

            for (int i = 0; i < number; i++ )
            {
                Console.Write("{0} ",randomNumber.Next(min, max));
            }

        }
    }
}
