//Write a program that converts a string to a sequence of C# Unicode character literals.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Unicode_Parser
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();
            Console.WriteLine("Unicode representation:{0}", ParseToUnicode(text));
        }

        static string ParseToUnicode(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++ )
            {
                result.Append(String.Format("\\u{0:X4}", (int)text[i]));
            }
            return result.ToString();
        }
    }
}
