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
            StringBuilder finalResult = new StringBuilder();
            
            for (int i = 0; i < words.Length; i++)
            {                
                BigInteger decimalValue = WordToDecimal(words[i], chars);
                string resultWord = DecimalToAlphabet(decimalValue, chars);
                finalResult.Append(resultWord);
                finalResult.Append(" ");
            }

            Console.WriteLine(finalResult.ToString());         
        }

        static BigInteger WordToDecimal(string word, char[]chars)
        {
            if(chars.Length < 1){
                throw new ArgumentException("Invalid chars input: Expected array of chars");
            }

            BigInteger sum = new BigInteger(0);
            for (int i = 0; i < word.Length; i++ )
            {
                BigInteger charDecimalValue = (BigInteger)Array.IndexOf(chars, word[i]);
                if (charDecimalValue > -1)
                {
                    BigInteger currentValue = charDecimalValue * BigInteger.Pow(21, word.Length - i - 1);
                    sum = BigInteger.Add(sum, currentValue);
                }
                else
                {
                    throw new Exception("Index of character not found");
                }
            }
            return sum;
        }

        static string DecimalToAlphabet(BigInteger number, char[] chars)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot convert to alphabet negative number");
            }

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
