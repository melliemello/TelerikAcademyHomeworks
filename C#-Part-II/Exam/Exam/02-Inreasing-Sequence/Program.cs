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
                int[] absoluteSeq = GetAbsoluteSeq(numbers);
                Console.WriteLine(IsIncreasing(absoluteSeq) ? "True" : "False");
                
            }


        }

        static int[] GetAbsoluteSeq(int[] numbers)
        {
            int[] absoluteSeq = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length-1; i++ )
            {
                absoluteSeq[i] = Math.Abs(Math.Max(numbers[i], numbers[i + 1]) - Math.Min(numbers[i], numbers[i + 1]));
            }
            return absoluteSeq;
        }

        static bool IsIncreasing(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++ )
            {
                int diff = numbers[i + 1] - numbers[i];
                if(diff > 1 || diff < 0 )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
