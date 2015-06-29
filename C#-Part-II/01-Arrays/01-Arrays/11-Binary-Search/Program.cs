//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;


class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Write down the sorted sequence to search in, use ',' as separator:");
        string[] charArray = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll<string, int>(charArray, int.Parse);
        Console.WriteLine("Write down the number to search for:");
        int numberToSearch = int.Parse(Console.ReadLine());

        int left = 0;
        int right = numbers.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (numbers[mid] == numberToSearch)
            {
                result = mid;
                break;
            }
            else if (mid < numberToSearch)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (result > -1)
        {
            Console.WriteLine("The index is:{0}", result);
        }
        else
        {
            Console.WriteLine("Number not found");
        }

    }


}
