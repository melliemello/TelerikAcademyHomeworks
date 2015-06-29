//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
using System;


namespace _05_Larger_Than_Neighbours
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 3, 2, 6, 3, 65, 34, 3, 4, 7, 8, 1 };
            int index = 3;
            int result = isLargerThanNeigbours(array, index);
            if(result > 0)
            {
                Console.WriteLine("The number {0} at position{1} is larger than its neighbours", array[index], index);
            }
            else if (result == 0)
            {
                Console.WriteLine("The number {0} at position{1} is smaller than its neighbours", array[index], index);
            }
            else
            {
                Console.WriteLine( "The number at position {0} doesn't have neighbours", index);
            }
            
        }

        static int isLargerThanNeigbours(int[] array, int index)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return 1;
            }
            else if (index == array.Length - 1 || index == 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

    }
}
