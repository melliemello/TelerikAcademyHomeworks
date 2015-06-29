using System;

namespace _04_Card_Deck
{
    class Program
    {
        static void Main()
        {
            string[] numbers = new string[13]{"2","3","4","5","6","7","8","9","10","J","D","K","A"};
            string[] colors = new string[4] { " of spades ", " of diamonds ", " of hearts ", " of clubs "};

            for (int i = 0; i < 13; i++ )
            {
                
                for (int j = 0; j < 4; j++ )
                {
                    Console.Write(numbers[i] + colors[j]);
                }
                Console.Write("\n");
            }

        }
    }
}
