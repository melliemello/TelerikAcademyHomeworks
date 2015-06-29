//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

namespace _04_Appearance_Count
{
    class Program
    {
        static void Main()
        {
            int[] array = {1,3,2,6,3,65,34,3,4,7,8,1};
            int numberToCheck = 3;
            int result = Appearance(array,numberToCheck) ;
            Console.WriteLine(result + " times");
        }

        static int Appearance(int[] array, int number)
        {
            int counter = 0;
            for(int i= 0; i < array.Length; i++)
            {
                if(array[i] == number )
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
