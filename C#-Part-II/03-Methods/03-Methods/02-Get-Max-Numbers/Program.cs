using System;


namespace _02_Get_Max_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write down 3 numbers:");
            int number1 = int.Parse(Console.ReadLine()) ;
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int max = GetMax(GetMax(number1, number2), number3);
            Console.WriteLine(max);
        }

        static int GetMax(int number1, int number2)
        {
            int max = number1;
            if(number2 > max)
            {
                max = number2;
            }
            return max;
        }
    }
}
