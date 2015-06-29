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
            int[,] matrixC = new int[size, size];
            int counter = 0;

            for (int i = size-1; i >= 0; i--)
            {
                
                for (int col = 0,row = i; col < size && row<size; col++, row++ )
                {
                    counter++;
                    matrixC[row, col] = counter;
                }
                
            }

            for (int i = 1; i < size; i++)
            {

                for (int col = i, row = 0; col < size && row < size; col++, row++)
                {
                    counter++;
                    matrixC[row, col] = counter;
                }

            }


            //Print the matrix

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("{0,4}", matrixC[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
