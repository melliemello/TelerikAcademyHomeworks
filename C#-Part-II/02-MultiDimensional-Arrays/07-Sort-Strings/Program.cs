//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;


namespace _07_Sort_Strings
{
    class SortStrings
    {
        static void Main()
        {
            string[] strings = {"ab", "afg", "a", "b", "aaaaa", "z", "544453560" };
            Array.Sort(strings, (str1, str2) => str1.Length.CompareTo( str2.Length));
            foreach(string str in strings)
            {
                Console.Write("{0} ", str);
            }
        }
    }
}
