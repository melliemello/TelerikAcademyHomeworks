using System;


namespace _09.PrintSequence
{
    class Program
    {
        static void Main()
        {
            PrintSequenceFrom(2, 10);
        }

        static void PrintSequenceFrom(int number, int length)
        {
            int i = 0;
            while (i < length)
            {
                Console.Write(number.ToString() + ", ");
                number = (Math.Abs(number) + 1) * number / Math.Abs(number) * -1;
                i++;
            }
        }
    }
}
