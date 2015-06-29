//Write a program that finds the maximal increasing sequence in an array
using System;
using System.Collections.Generic;

namespace _04_Maximal_Sequence_Of_Numbers
{
    class MaxSequence
    {
        static void Main()
        {
            Console.WriteLine("Write a program that finds the maximal sequence of equal elements in an array.");
            Console.WriteLine("Write down the sequence to check, use space as separator:");
            string[] charArray = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(charArray, int.Parse);

            int startIndex = 0;
            int endIndex = 0;
            int maxSequence = 1;
            int currentSequence = 1;
            

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] < numbers[i + 1])
                {
                    currentSequence++;
                    
                }
                else
                {
                    currentSequence = 1;
                    startIndex = i + 1;
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    endIndex = i + 1;
                    
                }

            }

            for (int i = startIndex; i <= endIndex; i++ )
            {
                Console.Write(numbers[i] + ",");
            }




        }
    }
}
