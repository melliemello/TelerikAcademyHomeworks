using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Forbidden_Words
{
    class Program
    {
        static void Main()
        {
            string[] words = new string[] { "PHP", "CLR", "Microsoft" };
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            for(int i = 0; i < words.Length; i++)
            {
                text = ReplaceWords(text, words[i]);
            }
            Console.WriteLine(text);
        }

        static string ReplaceWords(string text, string word)
        {
            int textIndex = 0;
            int wordIndex = 0;
            StringBuilder result = new StringBuilder();
            while(textIndex < text.Length - word.Length)
            {
                if (text[textIndex + wordIndex] == word[wordIndex])
                {
                    if (wordIndex == word.Length - 1)
                    {
                        text = text.Replace(text.Substring(textIndex, word.Length), new String('*', word.Length));
                        textIndex++;
                        wordIndex = 0;
                        continue;
                    }
                    wordIndex++;
                }
                else 
                {
                    textIndex++;
                    wordIndex = 0;
                }
            }

            return text;
        }
    }
}
