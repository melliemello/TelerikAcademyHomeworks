using System;

namespace _06_Four_Digit_Number
{
    class Four_Digit_Number
    {
        static void Main()
        {
            Console.WriteLine("Enter a 4 digit number:");
            short number = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Reversed:{0}", transformDigit(number, "reversed"));
            Console.WriteLine("Sum of the digits:{0}", transformDigit(number, "sum"));
            Console.WriteLine("Last digit in front::{0}", transformDigit(number, "lastInFront"));
            Console.WriteLine("Reversed 2nd and 3rd digit:{0}", transformDigit(number, "exchanged2and3"));

        }

        static int transformDigit(short number, string operation)
        { 
            int[] numberArray = new int[4];
            int result;
            numberArray[3] = number % 10;
            numberArray[2] = (number/10) % 10;
            numberArray[1] = (number / 100) % 10;
            numberArray[0] = (number / 1000);

            switch(operation)
            {
                case "reversed":
                   result = numberArray[3] * 1000 + numberArray[2] * 100 + numberArray[1] * 10 + numberArray[0];
                   break;
                case "sum":
                   result = numberArray[0] + numberArray[1] + numberArray[2] + numberArray[3];
                   break;
                case "lastInFront":
                   result = number / 10 + numberArray[3] * 1000;
                   break;
                case "exchanged2and3":
                   int temp = numberArray[1];
                   numberArray[1] = numberArray[2];
                   numberArray[2] = temp;
                   result = numberArray[0] * 1000 + numberArray[1] * 100 + numberArray[2] * 10 + numberArray[3];
                   break;
                default:
                   result = 0;
                   break;
            }

            return result;
        }
    }
}
