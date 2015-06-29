//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5
using System;


namespace _01_Allocate_Array
{
    class AllocateArray
    {
        static void Main()
        {
            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++ )
            {
                numbers[i] = i * 5;
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
