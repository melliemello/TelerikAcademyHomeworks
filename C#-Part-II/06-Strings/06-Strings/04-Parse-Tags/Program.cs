using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Parse_Tags
{
    class Program
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase>else";
            Console.WriteLine(ToUpper(text));

        }

        static string ToUpper(string text)
        {
            int openTag = 0;
            int closingTag = 0;
            string newString = text;
            bool isFinished = false;

            while(!isFinished)
            {
                openTag = text.IndexOf("<upcase>", closingTag);
                if (openTag > 0)
                {
                    closingTag = text.IndexOf("</upcase>", openTag );
                    int length = closingTag - openTag  ;
                    string oldContent = text.Substring(openTag , length+9);
                    string newContent = text.Substring(openTag + 8, length - 8).ToUpper();
                    newString = newString.Replace(oldContent, newContent);
                }
                else
                {
                    isFinished = true;
                }
            }

            return newString;
        }
    }
}
