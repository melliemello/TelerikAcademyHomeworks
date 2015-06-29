//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Collections.Generic;



namespace _07_Reverse_Number
{
    class Program
    {
        static void Main()
        {
            int[] array1 = {1,7,3,4,5,9,1,9 };
            int[] array2 = { 5,6,7,8};
            int[] sum = AddArrays(array1, array2);

            for (int i = sum.Length-1; i >=0; i--)
            {
                Console.Write(sum[i]);
            }

            
        }
        //Add the integers in the two arrays
        static int[] AddArrays(int[] array1, int[] array2)
        {
            List<int> sumArray = new List<int>();
            int maxLength = array1.Length;
            int minLength = array2.Length;
            int remainder = 0;

            if(array2.Length > maxLength)
            {
                maxLength = array2.Length;
                minLength = array1.Length;
            }

            int[] longestArray = new int[maxLength];
            if (array2.Length > maxLength)
            {
                Array.Copy(array2, longestArray, maxLength);
            }
            else
            {
                Array.Copy(array1, longestArray, maxLength);
            }

            //Adding the integers in both arrays
            for (int i = 0; i < minLength; i++ )
            {
                int currentSum = array1[i] + array2[i] + remainder;                
                if(currentSum >=10)
                {
                    remainder = currentSum % 10;
                    sumArray.Add(remainder);
                    remainder = 1;
                }
                else
                {
                    sumArray.Add(currentSum);
                    remainder = 0;
                }
                
            }

            //Adding the rest of the greater number or just the remainder if the lengths are equal:
            if (array2.Length == array1.Length)
            {
                if (remainder > 0)
                {
                    sumArray.Add(remainder);
                }
            }
            else 
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    int currentSum = longestArray[i] + remainder;
                    if (currentSum < 10)
                    {
                        sumArray.Add(currentSum);
                        remainder = 0;
                    }
                    else
                    {
                        sumArray.Add(remainder);
                        remainder = 1;
                    }
                }
            }     
            
            return sumArray.ToArray();
        }





            
        
    }
}
