//Write a program that finds in given array of integers a sequence of given sum S (if present)

using System;


class FindSum
{
    static void Main()
    {
        
        Console.WriteLine("Write down the sequence to sort, use ',' as separator:");
        string[] charArray = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll<string, int>(charArray, int.Parse);
        Console.WriteLine("Write down the sum to search for:");
        int S = int.Parse(Console.ReadLine());
        bool isFound = false;
        int startIndex = 0;
        int endIndex = 0;
        int currentSum = numbers[0];

        while (!isFound)
        {
            if(endIndex == numbers.Length - 1 || startIndex ==numbers.Length - 1 )
            {
                break;
            }

            if (currentSum == S)
            {
                isFound = true;
                break;
            }
            
            else if (currentSum < S )
            {
                endIndex++;
                currentSum += numbers[endIndex];
            }
            else 
            {
                currentSum -= numbers[startIndex];
                startIndex++;
            }
            
        }

        if (isFound)
        {
            for (int i = startIndex; i < endIndex ; i++)
            {
                Console.Write("{0},", numbers[i]);
            }
            Console.Write("{0}", numbers[endIndex]);
        }
        else
        {
            Console.Write("Sum not found");
        }


    }


}