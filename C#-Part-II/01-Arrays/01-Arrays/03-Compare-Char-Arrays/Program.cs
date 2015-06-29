//Write a program that compares two char arrays lexicographically (letter by letter).
using System;


namespace _03_Compare_Char_Arrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter char sequence N:1 :");
            char[] array1 = Console.ReadLine().ToCharArray();
            Console.WriteLine("Enter char sequence N:2 :");
            char[] array2 = Console.ReadLine().ToCharArray();
            int len1 = array1.Length;
            int len2 = array2.Length;
            string result = "The arrays are equal";

            if(len1 > len2)
            {
                result = "Array 1 is bigger than Array 2";
            }
            else if (len2 > len1)
            {
                result = "Array 2 is bigger than Array 1";
            }
            else
            {
                for (int i = 0; i < len1; i++)
                {
                    if(array1[i] > array2[i])
                    {
                        result = "Array 1 is bigger than Array 2";
                        break;
                    }
                    else if (array2[i] > array1[i])
                    {
                        result = "Array 2 is bigger than Array 1";
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
