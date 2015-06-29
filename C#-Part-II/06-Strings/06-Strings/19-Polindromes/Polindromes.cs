using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Polindromes
{
    class Polindromes
    {
        static void Main()
        {
            string text = "Here is some text with some words like ABBA : the first one is lamal, the second one is exe, and so on...";
            char[] separators = new char[]{',','.','!','?','-',' ', ':',';'};
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++ )
            {
                if(isPolindrome(words[i]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        static bool isPolindrome(string word)
        {
            int len = word.Length-1;
            int limit = (int)( Math.Ceiling((double)(len)/2));
            for (int i = 0; i < limit; i++ )
            {
                if ((int)word[i] != (int)word[len-i])
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
