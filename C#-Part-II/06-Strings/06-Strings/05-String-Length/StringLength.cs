using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_String_Length
{
    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            int  textLength = text.Length;
            if(textLength < 20)
            {
                text.Append(new String('*',20 - textLength));
            }
            Console.WriteLine(text);
        }
    }
}
