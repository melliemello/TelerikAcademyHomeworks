using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Words_Count
{
    class WordsCount
    {
        static void Main()
        {
            string text = "Here is some text with some words like ABBA : the first one is lamal, the second one is exe, and so on...";
            char[] separators = new char[] { ',', '.', '!', '?', '-', ' ', ':', ';' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (wordCounts.ContainsKey(words[i]))
                {
                    wordCounts[words[i]] += 1;
                }
                else
                {
                    wordCounts.Add(words[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> entry in wordCounts)
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
            
        }
    }
}
