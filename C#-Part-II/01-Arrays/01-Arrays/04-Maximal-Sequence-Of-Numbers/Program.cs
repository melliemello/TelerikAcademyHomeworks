//Write a program that finds the maximal sequence of equal elements in an array.
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


            int maxSequence = 1;
            int currentSequence = 1;
            int? element = null;
            string maxElements = "" ;

            for (int i = 0; i < numbers.Length - 1; i++ )
            {
                
                if (numbers[i] == numbers[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }

                if(currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    element = numbers[i];
                }

            }

            if(!element.Equals(null))
            {
                
                for(int i = 0; i < maxSequence; i++)
                {
                    maxElements += element + " ";
                }
                Console.WriteLine("The maximal sequence is {0}", maxElements);
            }


        }
    }
}
