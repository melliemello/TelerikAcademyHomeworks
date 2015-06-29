using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Matrix
{
    class Program
    {
        static void Main()
        {
            Matrix<int> testMatrix1 = new Matrix<int>(new int[2,3]{{1,2,3},{4,5,6}});
            Matrix<int> testMatrix2 = new Matrix<int>(new int[3,2] { {7,8}, {9,10},{11,12} });
            Matrix<int> testMatrix3 = new Matrix<int>(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, {7,8,9}});
            Matrix<int> testMatrix4 = new Matrix<int>(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, {7,8,9} });

            

            //Multiply 
            Console.WriteLine("Matrix 1:");
            Console.WriteLine(testMatrix1.ToString());

            Console.WriteLine("Matrix 2:");
            Console.WriteLine(testMatrix2.ToString());
            Console.WriteLine("Multiplication:");
            Console.WriteLine((testMatrix1 * testMatrix2).ToString());

            //Addition/ Substraction
            Console.WriteLine("Matrix 3:");
            Console.WriteLine(testMatrix3.ToString());

            Console.WriteLine("Matrix 4:");
            Console.WriteLine(testMatrix4.ToString());

            Console.WriteLine("Addition Matrix 3 + Matrix4:");
            Console.WriteLine((testMatrix3 + testMatrix4).ToString());

            Console.WriteLine("Substraction MAtrix3 - Matrix4:");
            Console.WriteLine((testMatrix3 - testMatrix4).ToString());

            //Indexer
            Console.WriteLine("Matrix3[2,2]:{0}",testMatrix3[2,2]);


        
        }
    }
}
