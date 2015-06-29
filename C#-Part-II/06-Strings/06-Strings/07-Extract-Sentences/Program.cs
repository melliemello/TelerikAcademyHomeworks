//Write a program that extracts from a given text all sentences containing given word.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Extract_Sentences
{
    class ExtractSentences
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string match = "in";
            char[] separators = { '.', '!', '?', ';' };
            string[] sentences = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            int j = 0;
            for(int i = 0; i < sentences.Length; i++)
            {
                int lastMatch = 0;
                while((lastMatch = sentences[i].IndexOf(match, lastMatch + match.Length)) > 0 ){
                    if(Char.ToUpper(sentences[i][lastMatch-1]) < 'A' || Char.ToUpper(sentences[i][lastMatch-1]) > 'Z'
                    && Char.ToUpper(sentences[i][lastMatch+match.Length]) < 'A' || Char.ToUpper(sentences[i][lastMatch+match.Length]) > 'Z' )
                    {
                        result.Append(sentences[i]);
                        break;
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
