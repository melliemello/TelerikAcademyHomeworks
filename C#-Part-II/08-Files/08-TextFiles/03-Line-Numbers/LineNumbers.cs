using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_Line_Numbers
{
    class LineNumbers
    {
        static void Main()
        {
            try
            {
                StreamReader file1 = new StreamReader(@"../../file1.txt");
                StreamWriter result = File.AppendText(@"../../result.txt");
                string line = "";
                int counter = 1;
                while((line = file1.ReadLine()) != null)
                {
                    result.WriteLine("{0}:{1}", counter, line);
                    counter++;
                }

                Console.WriteLine("Success!");
                result.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
