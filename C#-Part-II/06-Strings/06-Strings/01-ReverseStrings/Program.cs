using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter some text to reverse:");
            string text = Console.ReadLine();
            Console.WriteLine(Reverse(text));
        }

        static string Reverse(string text)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = text.Length-1; i >=0; i-- )
            {
                reversed.Append(text[i]);
            }
            return reversed.ToString();
        }
    }
}
