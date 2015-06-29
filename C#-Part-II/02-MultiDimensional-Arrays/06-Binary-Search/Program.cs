//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K

using System;


namespace _06_Binary_Search
{
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Write down the array, numbers should be separated by ',':");
            int[] numbers = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), int.Parse);
            Console.Write("Write down the number to search for:");
            int searchedNumber = int.Parse(Console.ReadLine());
            int len = numbers.Length;
            Array.Sort(numbers);

            int index = Array.BinarySearch<int>(numbers, searchedNumber); 
            if(index > 0 )
            {
                Console.WriteLine("The number is: {0} ",numbers[index]);
            }
            else if (~index < len) 
            {
                Console.WriteLine("All the numbers are greater than the number K");
                
            }
            else if (~index == len)
            {
                Console.WriteLine("The closeset number is: {0} ", numbers[~index - 1]);
            }
        }
    }
}
