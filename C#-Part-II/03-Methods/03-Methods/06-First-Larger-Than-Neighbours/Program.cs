

using System;


namespace _06_First_Larger_Than_Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 6, 3, 65, 34, 3, 4, 7, 8, 1 };

            int result = FirstLargerThanNeighbours(array);
            Console.WriteLine(result);
        }

        static int FirstLargerThanNeighbours(int[] array)
        {
            int result = -1;
            for(int i = 1; i < array.Length - 1; i++)
            {
                if (isLargerThanNeigbours(array, i) > 0)
                {
                    result = array[i];
                    break;
                }
               
            }
            return result;
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
