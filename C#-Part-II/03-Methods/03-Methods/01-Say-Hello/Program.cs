//Write a method that asks the user for his name and prints “Hello, <name>”
using System;

namespace _01_Say_Hello
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            SayHello(name);
        }

        static void SayHello(string name)
        {

            Console.WriteLine("Hello, {0}", name);
        }
    }
}
