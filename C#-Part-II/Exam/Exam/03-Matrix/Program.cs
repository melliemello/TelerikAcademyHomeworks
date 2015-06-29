using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] co = Array.ConvertAll<string, int>(Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            BigInteger[,]matrix = new BigInteger[rows,cols];
            for (int r = rows - 1; r >= 0; r--)
            {
                if (r < rows - 1)
                {
                    matrix[r, 0] = matrix[r + 1, 0] * 2;
                }
                else 
                {
                    matrix[r, 0] = 1;
                }
                //Console.Write(matrix[r, 0] + " ");
                for (int c = 1; c < cols; c++ )
                {
                    matrix[r, c] = matrix[r, c - 1] * 2;
                    //Console.Write(matrix[r, c] + " ");
                }
                //Console.WriteLine();
            }

            BigInteger sum = 0;
            int currentR = rows - 1;
            int currentC = 0;
            for (int i = 0; i < n; i++ )
            {
                int rt =(int) Math.Round((double)(co[i] / Math.Max(rows, cols)));
                int ct = co[i] % Math.Max(rows, cols);
                
                

                sum = sum + SumRow(matrix, Math.Min(ct, currentC), Math.Max(ct, currentC), currentR);
                currentC = ct;
                sum += SumCol(matrix, Math.Min(rt, currentR), Math.Max(rt, currentR), currentC);
                currentR = rt;
            }
            Console.WriteLine(sum);
        }

        static BigInteger SumRow(BigInteger[,]matrix, int startCol, int endCol, int row)
        {
            BigInteger currSum = 0;
            for (int i = startCol; i <= endCol; i++ )
            {
                currSum = currSum +  matrix[row, i];
                matrix[row, i] = 0;
            }
            return currSum;
        }

        static BigInteger SumCol(BigInteger[,] matrix, int startRow, int endRow, int col)
        {
            BigInteger currSum = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                currSum = currSum +  matrix[i,col];
                matrix[i, col] = 0;
            }
            return currSum;
        }
    }
}
