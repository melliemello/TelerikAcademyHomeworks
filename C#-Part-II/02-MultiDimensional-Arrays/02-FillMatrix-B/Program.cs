//Write a program that fills and prints a matrix of size (n, n) as shown below
using System;


namespace _01_Fill_Matrix
{
    class FillMatrix
    {
        static void Main()
        {
            Console.Write("write down the size N of the matrix:");
            int size = int.Parse(Console.ReadLine());
            int[,] matrixB = new int[size, size];

            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    if (col % 2 != 0 )
                    {
                        matrixB[row, col] = size * (col + 1) - row;
                    }
                    else
                    {
                        matrixB[row, col] = (size * col) + (row + 1);
                    }
                }
            }


            //Print the matrix

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("{0,4}", matrixB[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
