using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Order_Words
{
    class OrderWords
    {
        static void Main()
        {
            string text = "here are some words separated by spaces";
            char[] separators = new char[] { ',', '.', '!', '?', '-', ' ', ':', ';' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var sort = words.OrderBy(x => x);
            string[] sorted = sort.ToArray();

            for (int i = 0; i < sorted.Length; i++ )
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}
