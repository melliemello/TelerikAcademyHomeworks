using System;


namespace _04_Maximal_Sum
{
    class Program
    {
        static void Main()
        {
           Console.Write("write down the height of the matrix:");
           int rows = int.Parse(Console.ReadLine());

            Console.Write("write down the width of the matrix:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows,cols];

            int maxSum = Int32.MinValue;
            int currentSum = 0;
            int startRow = 0 ;
            int startCol = 0;


            //fill in the matrix

            for (int row = 0; row < rows ; row++ )
            {
                for (int col = 0; col < cols; col++ )
                {
                    Console.Write("Matrix{0}:{1}=",row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            //Solution

            for (int row = 0; row < rows - 2; row++ )
            {
                for (int col = row; col < cols - 2; col++ )
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                 matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                 matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if(currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startCol = col;
                        startRow = row;
                    }
                }
            }


            //Output

            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    Console.Write("{0,4}", matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
