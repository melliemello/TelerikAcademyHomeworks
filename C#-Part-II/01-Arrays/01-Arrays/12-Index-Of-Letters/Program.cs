//    Write a program that creates an array containing all letters from the alphabet (A-Z).
//    Read a word from the console and print the index of each of its letters in the array.


using System;


namespace _12_Index_Of_Letters
{
    class IndexOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Write down the word to be represented as char indices");
            string word = Console.ReadLine().ToUpper();
            char[] alphabet = new char[26];
            //Console.WriteLine((int)wordArray[0]);

            for (int i = 0; i < 26; i++ )
            {
                int currentChar = i + 65;
                alphabet[i] = (char)currentChar;                
            }

            for (int j = 0; j < word.Length; j++ )
            {
                char currentChar = word[j];
                Console.Write(Array.IndexOf(alphabet, currentChar));
            }
        }
    }
}
