//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;

namespace _05_Sequence_N_in_Matrix
{
    class Program
    {
        static void Main()
        {
            string[,] matrix= {
                            {"ha","ho","h0","ha"},
                            {"fo","ha","hi","xx"},
                            {"xxx","ho","ha","xx"},

                        }; 
           /* string[,] matrix = {
                            {"s","qq","s"},
                            {"pp","pp","s"},
                            {"pp","qq","s"},

                        }; */

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string currentelement = "";
            string mostFrequent = "";
            int max = 1;



            //Horizontal check
            for (int i = 0; i < rows ; i++)
            {
                int counter = 1;

                for (int j = 0;  j < cols - 1; j++)
                {
                    currentelement = matrix[i, j];

                    if (currentelement == matrix[i, j + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }

                    if (counter > max)
                    {
                        max = counter;
                        mostFrequent = currentelement;
                    }
                }
            }

            //Vertical check
            for (int i = 0; i < cols; i++)
            {
                int counter = 1;

                for (int j = 0; j < rows - 1; j++)
                {
                    currentelement = matrix[j,i];

                    if (currentelement == matrix[j + 1,i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }

                    if (counter > max)
                    {
                        max = counter;
                        mostFrequent = currentelement;
                    }
                }
            }

            //Diagonal check
            for (int i = 0; i < cols ; i++)
            {
                int counter = 1;

                for (int j = i; j < rows - 1 && j < cols - 1; j++)
                {
                    currentelement = matrix[j, j];

                    if (currentelement == matrix[j + 1, j + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }

                    if (counter > max)
                    {
                        max = counter;
                        mostFrequent = currentelement;
                    }
                }
            }

            for(int i = 0; i < max; i++)
            {
                Console.Write("{0} ", mostFrequent);
            }
        }
    }
}
