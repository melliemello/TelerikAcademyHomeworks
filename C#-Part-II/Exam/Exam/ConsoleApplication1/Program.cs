using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            char[] chars = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
            string[] words = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder final = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                
                BigInteger decimalValue = ToDecimal(words[i], chars);
                string resultWord = ToAlphabet(decimalValue, chars);
                final.Append(resultWord);
                final.Append(" ");
            }

            Console.WriteLine(final.ToString());
            

        }

        static BigInteger ToDecimal(string word, char[]chars)
        {
            BigInteger sum = new BigInteger(0);
            for (int i = 0; i < word.Length; i++ )
            {

                BigInteger current = (BigInteger)Array.IndexOf(chars,word[i]) * BigInteger.Pow(21, word.Length - i - 1);
                sum = BigInteger.Add( sum, current );
            }
            return sum;
        }

        static string ToAlphabet(BigInteger number, char[] chars)
        {
            StringBuilder result = new StringBuilder();
            while(number > 0)
            {
                BigInteger remainder = number % (BigInteger)26;
                result.Insert (0,chars[(int)remainder]);
                number = BigInteger.Divide(number, (BigInteger)26);
            }

            return result.ToString();
        }
    }
}
