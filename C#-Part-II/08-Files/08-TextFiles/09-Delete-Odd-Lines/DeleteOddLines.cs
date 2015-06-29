
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file
using System;
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
           StringBuilder text = new StringBuilder();
           string line = "";
           int counter=0;
           string filePath = "../../file.txt";

           StreamReader file = new StreamReader(filePath);
           using(file)
           {
               try
               {
                   while ((line = file.ReadLine()) != null)
                   {
                       if (counter % 2 == 0)
                       {
                           text.Append(line);
                           text.Append(Environment.NewLine);
                       }
                       counter++;
                   }
               }
               catch (FileNotFoundException)
               {
                   Console.WriteLine("File {0} not found", filePath);
               }

           }

            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(text);
            }
        }


    }
}
