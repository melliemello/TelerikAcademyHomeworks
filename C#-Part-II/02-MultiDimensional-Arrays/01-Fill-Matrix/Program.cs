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
            int[,] matrixA = new int[size, size];

            for (int i = 0; i < size; i++ )
            {
                int currentNumber = i + 1;
                for (int j = 0; j < size; j++ )
                {
                    matrixA[i, j] = currentNumber;
                    currentNumber += size;
                    Console.Write("{0,5}",matrixA[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
