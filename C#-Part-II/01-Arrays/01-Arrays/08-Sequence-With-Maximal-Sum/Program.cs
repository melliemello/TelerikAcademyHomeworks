//Write a program that finds the sequence of maximal sum in given array
using System;


namespace _08_Sequence_With_Maximal_Sum
{
    class MaxSumSequence
    {
        static void Main()
        {
            Console.WriteLine("Write a program that finds the sequence of maximal sum in given array");
            Console.WriteLine("Write down the sequence to check, use ',' as separator:");
            string[] charArray = Console.ReadLine().Split(',');
            int[] numbers = Array.ConvertAll<string, int>(charArray, int.Parse);

            int startIndex = 0;
            int endIndex = 0;
            int maxSum = Int32.MinValue;
            int currentSum = 0;
            string result = "";

            for (int i = 0; i < numbers.Length; i++ )
            {
                for (int j = i; j < numbers.Length; j++ )
                {
                    currentSum += numbers[j];
                    if(currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startIndex = i;
                        endIndex = j;
                    }
                }
                currentSum = 0;
            }

            for (int i = startIndex; i <= endIndex; i++ )
            {
                result += numbers[i] + " ";
            }
            Console.WriteLine("The sequence is:{0} and the sum is: {1}", result, maxSum);
        }
    }
}
