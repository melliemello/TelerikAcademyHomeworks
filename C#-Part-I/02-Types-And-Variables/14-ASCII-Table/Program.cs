using System;


namespace _14_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar;
            for (int i = 0; i < 256; i++ )
            {
                myChar = (char)i;
                Console.WriteLine(myChar);
            }
        }
    }
}
