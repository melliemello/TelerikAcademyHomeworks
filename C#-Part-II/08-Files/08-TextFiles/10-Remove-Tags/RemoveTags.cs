using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _10_Remove_Tags
{
    class RemoveTags
    {
        static void Main()
        {
            string text = "";
            string res = "";
            try
            {
                using(StreamReader file = new StreamReader("../../file.txt"))
                {
                    text = file.ReadToEnd();
                }
                text = Regex.Replace(text,@"<[^>]+>"," ");
                Console.WriteLine(text);
                
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File faled to load");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
