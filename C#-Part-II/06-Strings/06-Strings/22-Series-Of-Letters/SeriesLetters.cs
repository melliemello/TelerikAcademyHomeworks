using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Series_Of_Letters
{
    class SeriesLetters
    {
        static void Main(string[] args)
        {


            string text = "sddddddddddddddsfaaaaaadsfdffffffffff";
            text = ReplaceWords(text);
            Console.WriteLine(text);
        }

        static string ReplaceWords(string text)
        {
            int textIndex = 0;
            int matchCount = 1;

            while(textIndex < text.Length - matchCount )
            {
                if (text[textIndex + matchCount] != text[textIndex] && matchCount > 1 ||
                    textIndex + matchCount == text.Length - 1 && matchCount > 1)
                {
                    text = text.Replace(text.Substring(textIndex, matchCount), text[textIndex].ToString());
                    textIndex++;
                    matchCount = 1;
                }
                else if (text[textIndex + matchCount] == text[textIndex])
                {
                    matchCount++;
                    continue;
                }
                textIndex++;
            }

            return text;
            
        }
    }
}
