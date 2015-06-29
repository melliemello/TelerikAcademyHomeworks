using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Matrix
{
    public class Matrix<T> where T : struct, 
                              IComparable,
                              IComparable<T>,
                              IConvertible,
                              IEquatable<T>,
                              IFormattable 
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[this.rows,this.cols];
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            this.rows = matrix.GetLength(0);
            this.cols = matrix.GetLength(1);
        }


        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value > 0)
                {
                    this.rows = value;
                }
                else
                {
                    Console.WriteLine("The number of rows should be positive number");
                }
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value > 0)
                {
                    this.cols = value;
                }
                else
                {
                    Console.WriteLine("The number of cols should be positive number");
                }
            }
        }

        public static Matrix<T> operator + (Matrix<T> matrix1,Matrix<T> matrix2 )
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new FormatException("the matrices should be with equal size in order to apply any operator");
            }
            else
            {
                T[,] resultMatrix = new T[matrix1.Rows, matrix1.Cols];
                for (int row = 0; row < matrix1.Rows; row++)
                {
                    for (int col = 0; col < matrix1.Cols; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrix1[row, col] + (dynamic)matrix2[row, col];
                    }
                }

                return new Matrix<T>(resultMatrix);
            }
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new FormatException("the matrices should be with equal size in order to apply any operator");
            }
            else
            {
                T[,] resultMatrix = new T[matrix1.Rows, matrix1.Cols];
                for (int row = 0; row < matrix1.Rows; row++)
                {
                    for (int col = 0; col < matrix1.Cols; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrix1[row, col] - (dynamic)matrix2[row, col];
                    }
                }

                return new Matrix<T>(resultMatrix);
            }
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Cols || matrix2.Rows != matrix1.Cols)
            {
                throw new FormatException("the size of the matrices doesn't allow multiplication");
            }
            else
            {
                T[,] resultMatrix = new T[matrix1.Rows, matrix2.Cols];
                for (int row = 0; row < matrix1.Rows; row++)
                {
                    for (int col = 0; col < matrix2.Cols; col++)
                    {
                        T currentResult = (dynamic)0;
                        for (int m = 0; m < matrix1.Cols; m++)
                        {
                            currentResult += (dynamic)matrix1[row, m] * (dynamic)matrix2[m, col];
                        }
                        resultMatrix[row, col] = currentResult;
                    }
                }
                return new Matrix<T>(resultMatrix);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for(int row= 0 ; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++ )
                {
                    result.Append(this.matrix[row,col]);
                    result.Append(" " );
                }
                result.Append(Environment.NewLine );
            }
            return result.ToString();
        }

        public T this[int row,int col]
        {
            get
            {
                if (IsValidIndex(this.matrix, row, col))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The requested row and col of the matrix are out of range");
                }
            }
        }

        private bool IsValidIndex(T[,] matrix, int row, int col)
        {
            if(col >= 0&&row >= 0 &&  row < this.rows && col < this.cols )
            {
                return true;
            }
            return false;
        }

        
    }
}
