//Write a program that finds the most frequent number in an array.
using System;

namespace _09_Frequent_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a program that finds the most frequent number in an array");
            Console.WriteLine("Write down the sequence to check, use ',' as separator:");
            string[] charArray = Console.ReadLine().Split(',');
            int[] numbers = Array.ConvertAll<string, int>(charArray, int.Parse);            
            int maxFrequency = 0;
            int currentFrenquency = 1;
            int element = 0;

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length - 1; i++ )
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentFrenquency++;
                }
                else
                {
                    currentFrenquency = 1;
                }
                if(currentFrenquency > maxFrequency)
                {
                    maxFrequency = currentFrenquency;
                    element = numbers[i];
                }
            }

            Console.WriteLine("The most frequent numbers is: {0}, present {1} times", element, maxFrequency);
        }
    }
}
