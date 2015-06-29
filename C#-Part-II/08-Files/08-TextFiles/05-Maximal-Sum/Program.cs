//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_Compare_Files
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int[][] matrix = new int[n][];
            int maxSum = int.MinValue;
            int currentSum = 0;
            try
            {
                StreamReader file = new StreamReader(@"../../file1.txt");
                string line = "";
                int counter = 0;
                while ((line = file.ReadLine()) != null && counter < n )
                {
                    string[] t = line.Split(' ');
                    matrix[counter] = Array.ConvertAll<string,int>(t, int.Parse);
                    counter++;
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

            for (int row = 0; row < n-1; row++ )
            {
                for (int col = 0; col < n-1; col++ )
                {
                    currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row+1][col] + matrix[row+1][col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
