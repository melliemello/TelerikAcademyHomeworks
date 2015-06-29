using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace _11_Remove_Prefix
{
    class RemovePrefix
    {
        static void Main(string[] args)
        {
            string pattern = @"(\b)test[a-z0-9_]*(\b)";
            string text = "";
            string replaced = "";

            try
            {
                using(StreamReader file = new StreamReader("../../file.txt") )
                {
                    text = file.ReadToEnd();
                    replaced = Regex.Replace(text, pattern, "");
                    Console.WriteLine(replaced);
                }
            }
            catch(FileLoadException)
            {
                Console.WriteLine("File failed t load");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            
        }
    }
}
