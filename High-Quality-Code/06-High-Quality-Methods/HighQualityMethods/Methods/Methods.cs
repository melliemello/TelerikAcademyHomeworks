using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityMethods.Methods
{
    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            bool isZeroOrNegativeNumber = a <= 0 || b <= 0 || c <= 0;            
            if (isZeroOrNegativeNumber)
            {
                throw new ArgumentOutOfRangeException("TriangleSide", "A triangle side cannot be 0 or negative number");
            }

            bool isPossibleTriangle = a + b > c && a + c > b && b + c > a;
            if (!isPossibleTriangle)
            {
                throw new ArgumentException("Sides cannot make a traingle");
            }

            double halfParameter = (a + b + c) / 2;
            double area = Math.Sqrt(halfParameter * (halfParameter - a) * (halfParameter - b) * (halfParameter - c));
            return area;
        }

        public static string DigitToString(byte digit)
        {
            if (digit < 0 || 10 <= digit)
            {
                throw new ArgumentOutOfRangeException("digit", "Input number should be in the range 0 - 9");
            }

            string digitAsText;
            switch (digit)
            {
                case 0: 
                    digitAsText = "zero";
                    break;
                case 1:
                    digitAsText = "one";
                    break;
                case 2:
                    digitAsText = "two";
                    break;
                case 3:
                    digitAsText = "three";
                    break;
                case 4:
                    digitAsText = "four";
                    break;
                case 5:
                    digitAsText = "five";
                    break;
                case 6:
                    digitAsText = "six";
                    break;
                case 7:
                    digitAsText = "seven";
                    break;
                case 8:
                    digitAsText = "eight";
                    break;
                case 9:
                    digitAsText = "nine";
                    break;
                default:
                    throw new Exception("Somthing went wrong, can't convert digit to text");
            }

            return digitAsText;
        }

        public static int FindMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentNullException("numbers", "Input cannot be null ot empty");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[0])
                {
                    numbers[0] = numbers[i];
                }
            }

            return numbers[0];
        }

        public static void PrintAsNumber(object number, string format)
        {
            if (!IsNumeric(number))
            {
                throw new ArgumentException("Input value is not a number; Expected a numeric type");
            }

            string formatTemplate = string.Empty;

            switch (format)
            {
                case "f":
                    formatTemplate = "{0:f2}";
                    break;
                case "%":
                    formatTemplate = "{0:p0}";
                    break;
                case "r":
                    formatTemplate = "{0,8}";
                    break;
                default:
                    throw new ArgumentException("Input is not a valid format; Expected 'f', '%' ot 'r'");
            }

            Console.WriteLine(formatTemplate, number);
        }

        public static bool IsNumeric(object expression)
        {
            if (expression == null)
            {
                return false;
            }

            switch (Type.GetTypeCode(expression.GetType()))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        public static Distance CalcDistance(double x1, double y1, double x2, double y2)
        {
            bool isHorizontal = y1 == y2;
            bool isVertical = x1 == x2;

            double calculatedDistance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Distance distance = new Distance(calculatedDistance, isHorizontal, isVertical);
            return distance;
        }
    }
}
