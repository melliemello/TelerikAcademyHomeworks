/// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
/// If an invalid number or non-number text is entered, the method should throw an exception. 
/// Using this method write a program that enters 10 numbers:	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;

class EnterNumbers
{
    static void Main()
    {

        int start = 1;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Input a number: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                ReadNumber(number, start); 
                Console.WriteLine("{0} is in range!", number);
                start = number; 
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (FormatException) 
            {
                Console.Error.WriteLine("Input is NOT a valid number!");
            }
            catch (Exception ex) 
            {
                string errMassage = string.Format("{0} That leads to {1}", ex.Message, ex.GetType());
                Console.Error.WriteLine(errMassage);
            }

        }
        
    }
    static void ReadNumber(int value, int start = 1, int end = 100)
    {
        if ((value < start) || (value > end))
        {
            throw new ArgumentOutOfRangeException(
                "Input number is out of range!");
        }
    }

}

