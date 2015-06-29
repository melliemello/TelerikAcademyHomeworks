/// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
/// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class ReplaceSubstring
{
    static void Main(string[] args)
    {
        try
        {
            string pattern = "start";
            string changed = "finish";
            StringBuilder result = new StringBuilder();

            foreach (string line in File.ReadLines(@"../../file1.txt"))
            {
                if (line.Contains(pattern))
                {
                    result.Append(line.Replace(pattern, changed));
                }
                else
                {
                    result.Append(line);
                }
                result.Append(Environment.NewLine);
            }


            using (StreamWriter sr = new StreamWriter(@"../../result.txt"))
            {
                sr.Write(result);
            }

            Console.WriteLine("Succes!");
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }
}

