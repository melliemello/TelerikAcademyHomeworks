/// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
/// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReplaceSubstring
{
    static void Main(string[] args)
    {
        try
        {
            string pattern = "start";
            string changed = "finish";
            string newLine = "";
            StringBuilder result = new StringBuilder();

            foreach (string line in File.ReadLines(@"../../file1.txt", Encoding.GetEncoding(1251)))
            {
                if (line.Contains(pattern))
                {
                    newLine = Regex.Replace(line, @"(\b)start(\b)", "finish");
                    newLine = Regex.Replace(newLine, @"(\s)start(\s)", "finish");
                    result.Append(newLine + Environment.NewLine);
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
            Console.Error.WriteLine("The process failed: {0}", e.Message);
        }
    }
}

