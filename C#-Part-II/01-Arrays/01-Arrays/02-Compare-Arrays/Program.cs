//Write a program that reads two integer arrays from the console and compares them element by element.
using System;

namespace _02_Compare_Arrays
{
    class CompareArrays
    {
        static void Main()
        {

            Console.WriteLine("Enter the numbers of Array 1, spearated by space:");
            string[] array1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter the numbers of Array 2, spearated by space:");
            string[] array2 = Console.ReadLine().Split(' ');
            bool isEqual = true;
            int len1 = array1.Length;
            int len2 = array2.Length;
   

            if (len1 != len2)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < len1; i++ )
                {
                    if (array1[i] != array2[i])
                    {
                        isEqual = false;
                    }
                }
            }

            Console.WriteLine("The arrays are equal: {0}", isEqual);
           
        }
    }
}
