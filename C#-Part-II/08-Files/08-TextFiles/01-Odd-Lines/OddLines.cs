using System;
//Write a program that reads a text file and prints on the console its odd lines
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_Odd_Lines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader file = new StreamReader("file.txt");
            string line = "";
            int counter = 1;

            while((line = file.ReadLine()) != null)
            {
                if(counter % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }
            file.Close();
        }

        
    }
}
