//    Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;


namespace _06_Maximal_K_Sum
{
    class MaximalKSum
    {
        static void Main()
        {
            Console.WriteLine("Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum");
            Console.WriteLine("Enter the length of the sequence you want to check:"); 
            int sequenceLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the the sequence you want to check, numbers should be separated by space:");
            string[] charArray = Console.ReadLine().Split(' ');

            int[] numbers = Array.ConvertAll<string, int>(charArray, int.Parse);
            int currentSum = 0;
            string result = "";
            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int i = 0; i < sequenceLength; i++ )
            {
                currentSum += numbers[i];
                result += numbers[i] + " ";
            }

            Console.WriteLine("the numbers with maximal sum are:{0}, the sum is {1}", result, currentSum);
        }
    }
}
