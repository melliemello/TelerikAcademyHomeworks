using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HighQualityMethods.Methods
{
    internal class EntryPoint
    {
        internal static void Main()
        {
            // TEST Print digit as string
            Dictionary<object, string> printAsNumberTestData = new Dictionary<object, string> 
            {
                { 1.3, "f" },
                { 0.75, "%" },
                { 2.30, "r" }
            };
            TestPrintAsNumber(printAsNumberTestData);

            // Test Traingle Area 
            double[,] testTriangleAreaData = new double[1, 3] 
            { 
               { 3, 4, 5 } 
            };
            TestCalcTriangleArea(testTriangleAreaData);

            // Test Digit as String 
            byte[] digitAsStringTestData = new byte[] { 1, 3, 5, 7 };
            TestDigitToString(digitAsStringTestData);

            // TestFindMax
            double[][] testFindMaxData = new double[][] 
            { 
                 new double[] { -60, 1, 3, 5, 50 }
            };
            TestFindMax(testFindMaxData);
        }

        private static void TestPrintAsNumber(Dictionary<object, string> testData)
        {
            foreach (var number in testData)
            {
                Methods.PrintAsNumber(number.Key, number.Value);
            }
        }

        private static void TestCalcTriangleArea(double[,] testData)
        {
            if (testData == null || testData.GetLength(0) < 1)
            {
                throw new ArgumentException("Cannot run tests with empty data");
            }

            if (testData.GetLength(1) != 3)
            {
                throw new ArgumentException("Cannot run tests, Expected 3 input values insted of" + testData.GetLength(1));
            }

            int n = testData.GetLength(0);
            for (int i = 0, len = testData.GetLength(0); i < len; i++)
            {
                double a = testData[i, 0];
                double b = testData[i, 1];
                double c = testData[i, 2];

                Console.WriteLine(Methods.CalcTriangleArea(a, b, c));
            }
        }

        private static void TestDigitToString(byte[] testData)
        {
            if (testData == null || testData.Length == 0)
            {
                throw new ArgumentException("Cannot run tests with empty data");
            }

            for (int i = 0, len = testData.Length; i < len; i++)
            {
                Console.WriteLine(Methods.DigitToString(testData[i]));
            }
        }

        // TODO: Extract Validation Rules
        private static void TestFindMax(double[][] testData)
        {
            if (testData == null || testData.GetLength(0) < 1)
            {
                throw new ArgumentException("Cannot run tests with empty data");
            }

            for (int i = 0, len = testData.GetLength(0); i < len; i++)
            {
                double firstX = testData[i][0];
                double secondX = testData[i][1];
                double firstY = testData[i][2];
                double secondY = testData[i][3];

                Distance distance = Methods.CalcDistance(firstX, secondX, firstY, secondY);
                Console.WriteLine(distance.Value);
                Console.WriteLine("Horizontal? " + distance.IsHorizontal);
                Console.WriteLine("Vertical? " + distance.IsVertical);
            }
        }
    }
}
