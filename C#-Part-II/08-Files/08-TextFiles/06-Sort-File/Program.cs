/// Write a program that reads a text file containing a list of strings,
/// sorts them and saves them to another text file. 

using System;
using System.IO;
using System.Collections.Generic;

class SortStrings
{
    static void Main(string[] args)
    {

        try
        {
            List<string> inputArray = new List<string>();
            foreach (string line in File.ReadLines(@"../../file1.txt"))
            {
                inputArray.Add(line);

            }
            inputArray.Sort();

            using (StreamWriter sr = new StreamWriter(@"../../result.txt"))
            {
                foreach (string item in inputArray)
                {
                    sr.WriteLine(item);
                }
            }

            Console.WriteLine("Succes!");
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }
}

