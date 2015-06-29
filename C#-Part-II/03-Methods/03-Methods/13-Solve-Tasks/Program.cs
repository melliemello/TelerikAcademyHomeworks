using System;


namespace _13_Solve_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option: \n 1 for reversin a number; \n 2 for finding the average sum of a sequence \n 3 for solving a * x + b = 0");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter a nemuber to reverse:");
                    int number = int.Parse(Console.ReadLine());
                    int? result = ReverseNumber(number);
                    Console.WriteLine("The reversed number is: {0}", result.Equals(null) ? "Enter a positive number": Convert.ToString(result));
                    break;
                case 2:
                    Console.WriteLine("Enter a sequence, separated by ',':");
                    string input;
                    if (!isValidSequence(input = Console.ReadLine()));
                    {
                        Console.WriteLine("Please enter a valid sequence");
                    }
                    
                    double? result2 = Average(input);
                    Console.WriteLine("the average number is: {0}", result2.Equals(null) ? "The sequence should not be empty" : Convert.ToString(result2));
                    break;
                case 3:
                    Console.WriteLine("Enter a and b for 'a * x + b = 0':");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double? result3 = SolveEquation(a,b);
                    Console.WriteLine("The result is: {0}",  result3.Equals(null) ? "The value for A should not be 0" : Convert.ToString(result3));
                    break;
                    
            }
        }

        static double? SolveEquation(double a, double b)
        {
            if (isPositive(a))
            {
                double resEquation = (-1 * b) / a;
                return resEquation;
            }
            else
            {
                return null;
            }
            
        }

        static int? ReverseNumber(int number)
        {

            if(number < 0)
            {
                return null;
            }
            int reversedNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return reversedNumber;
        }

        static double? Average(string number)
        {
            string[] arr = number.Split(',');
            int[] numbers = Array.ConvertAll<string, int>(arr, int.Parse);         
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++ )
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        static bool isValidSequence(string input)
        {
            if (input == String.Empty)
            {
                return false;
            }
            return true;
        }

        static bool isPositive(double number)
        {
            if (number > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        
    }
}
