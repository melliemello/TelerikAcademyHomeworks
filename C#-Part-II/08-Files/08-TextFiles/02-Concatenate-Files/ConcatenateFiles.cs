//Write a program that concatenates two text files into another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02_Concatenate_Files
{
    class ConcatenateFiles
    {
        static void Main()
        {
            
            try
            {
                StreamReader file1 = new StreamReader(@"../../file1.txt");
                StreamReader file2 = new StreamReader(@"../../file2.txt");
                StreamWriter result = File.AppendText(@"../../result.txt");
                result.Write(file1.ReadToEnd());
                result.Write(file1.ReadToEnd());
                Console.WriteLine("Success!");
                result.Close();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found" );
            }
             
        }
    }
}
