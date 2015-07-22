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
            int numberOfMoves = int.Parse(Console.ReadLine());
            int[] path = Array.ConvertAll<string, int>(Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            BigInteger[,] playfield = GeneratePlayfield(rows, cols);

            BigInteger sum = 0;
            int currentRow = rows - 1;
            int currentCol = 0;
            for (int i = 0; i < numberOfMoves; i++ )
            {                
                int targetCol = path[i] % Math.Max(rows, cols);
                int startColumn = Math.Min(targetCol, currentCol);
                int endColumn = Math.Max(targetCol, currentCol);

                sum = sum + SumRow(playfield, startColumn, endColumn, currentRow);
                currentCol = targetCol;

                int targetRow = (int)Math.Round((double)(path[i] / Math.Max(rows, cols)));
                int startRow = Math.Min(targetRow, currentRow);
                int endRow = Math.Max(targetRow, currentRow);

                sum += SumColumn(playfield, startRow, endRow, currentCol);
                currentRow = targetRow;
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

        static BigInteger SumColumn(BigInteger[,] matrix, int startRow, int endRow, int col)
        {
            BigInteger currentSum = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                currentSum = currentSum +  matrix[i,col];
                matrix[i, col] = 0;
            }
            return currentSum;
        }

        static BigInteger[,] GeneratePlayfield(int rows, int cols)
        {
            BigInteger[,]playfield = new BigInteger[rows,cols];
            for (int row = rows - 1; row >= 0; row--)
            {
                if (row < rows - 1)
                {
                    playfield[row, 0] = playfield[row + 1, 0] * 2;
                }
                else 
                {
                    playfield[row, 0] = 1;
                }

                for (int col = 1; col < cols; col++ )
                {
                    playfield[row, col] = playfield[row, col - 1] * 2;
                }
            }

            return playfield;
        }
    }
}
