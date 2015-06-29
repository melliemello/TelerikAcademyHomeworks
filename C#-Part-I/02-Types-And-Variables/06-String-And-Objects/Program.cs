using System;

namespace _06_String_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = "Hello";
            string part2 = "World!";
            object whole = part1 + " " + part2;
            string wholeString = Convert.ToString(whole);
            Console.WriteLine(whole);
        }
    }
}
