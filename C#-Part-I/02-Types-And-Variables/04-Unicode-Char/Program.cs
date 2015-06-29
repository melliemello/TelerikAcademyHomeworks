using System;

namespace _04_Unicode_Char
{
    class Program
    {
        static void Main()
        {
            string charUnicode = "\u002A";
            char character = Convert.ToChar(charUnicode); 
            Console.WriteLine(character);
        }
    }
}
