//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;


class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Write down the sequence to sort, use ',' as separator:");
        string[] charArray = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll<string, int>(charArray, int.Parse); 

        int minIndex = 0;
        int len = numbers.Length;
        for (int i = 0; i < len; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < len; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }

            if (numbers[i] != numbers[minIndex])
            {
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }

        for (int i = 0; i < len; i++)
        {
            if (i != len - 1)
            {
                Console.Write(numbers[i] + ",");
            }
            else
            {
                Console.Write(numbers[i]);
            }
        }
    }


}