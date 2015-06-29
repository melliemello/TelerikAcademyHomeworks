//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Letters_Count
{
    class LettersCount
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();

            char[] chars = text.ToCharArray();
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++ )
            {
                if (charCounts.ContainsKey(chars[i]))
                {
                    charCounts[chars[i]] += 1;
                }
                else
                {
                    charCounts.Add(chars[i], 1);
                }
            }

            foreach(KeyValuePair<char, int> entry in charCounts )
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
            
        }
    }
}
