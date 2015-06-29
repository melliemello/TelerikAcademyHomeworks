using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Encode_Decode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Enter a text to encode:");
            string text = Console.ReadLine();
            string key = "alabala";
            string encoded = Encode(text, key);
            string decoded = Encode(encoded, key);
            Console.WriteLine("Encoded string is:{0}:" ,encoded);
            Console.WriteLine("Decoded string is:{0}:",decoded);
        }

        static string Encode(string text, string key)
        {
            int len = text.Length;
            int keyLen = key.Length;
            int i = 0;
            StringBuilder encodedText = new StringBuilder();
            while(i < len)
            {                
                int a = (int)text[i];
                int b = (int)key[i % keyLen];
                encodedText.Append((char)( a ^ b));
                i++;
            }
            return encodedText.ToString();
        }
    }
}
