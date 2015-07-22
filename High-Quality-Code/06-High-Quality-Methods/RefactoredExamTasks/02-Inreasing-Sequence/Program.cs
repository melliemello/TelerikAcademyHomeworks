using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inreasing_Sequence
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++ )
            {
                int[] numbers = Array.ConvertAll<string,int>(Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int[] absoluteSeqence = GetAbsoluteSeqence(numbers);
                Console.WriteLine(IsIncreasingSequence(absoluteSeqence) ? "True" : "False");               
            }
        }

        static int[] GetAbsoluteSeqence(int[] numbers)
        {
            ValidateSequence(numbers);

            int[] absoluteSequence = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length-1; i++ )
            {
                absoluteSequence[i] = Math.Abs(Math.Max(numbers[i], numbers[i + 1]) - Math.Min(numbers[i], numbers[i + 1]));
            }

            return absoluteSequence;
        }

        internal static bool IsIncreasingSequence(int[] numbers)
        {
            ValidateSequence(numbers);

            for (int i = 0; i < numbers.Length - 1; i++ )
            {
                int difference = numbers[i + 1] - numbers[i];
                if(difference > 1 || difference < 0 )
                {
                    return false;
                }
            }

            return true;
        }
        
        internal static void ValidateSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                throw new ArgumentException("The sequnce should contain at least 2 numbers");
            }
        }
    }
}
