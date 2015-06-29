using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Longest_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] { "sofg","fgdfgdfgfdg", "fgdfg","erere","f" };
            Console.WriteLine("List of strings:");
            foreach(string str in strings)
            {
                Console.Write("{0} ", str);
            }
            Console.WriteLine("{0} --------------------------------------", Environment.NewLine);
            string result = (from str in strings
                            orderby str.Length
                            select str).Last();

            Console.WriteLine("The longest string is {0}",result);
        }
    }
}
