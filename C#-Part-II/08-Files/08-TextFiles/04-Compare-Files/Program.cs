using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_Compare_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader file1 = new StreamReader(@"../../file1.txt");
                StreamReader file2 = new StreamReader(@"../../file2.txt");
                string line1 = "";
                int differentCounter = 0;
                int equalCounter = 0;
                while((line1 = file1.ReadLine())!= null)
                {
                    if(line1 == (file2.ReadLine()))
                    {
                        equalCounter++;
                    }
                    else
                    {
                        differentCounter++;
                    }
                }
                file1.Close();
                file2.Close();
                Console.WriteLine("Different Lines:{0}\n Equal Lines:{1}", differentCounter, equalCounter);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
