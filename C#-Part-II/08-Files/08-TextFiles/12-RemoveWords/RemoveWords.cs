//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12_RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            List<string> words = new List<string>();
            string text = "";
            char[] separators = new char[] {' ', '\n', ',' };


            try
            {
                using (StreamReader wordsFile = new StreamReader("../../words.txt"))
                {
                    words = wordsFile.ReadToEnd().ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

                }
                using (StreamReader textFile = new StreamReader("../../text.txt"))
                {
                    text = textFile.ReadToEnd();
                    Console.WriteLine("Inital text: {0}", text);
                    Console.WriteLine("Words to clear:");
                }
                foreach (string word in words)
                {
                    Console.Write(word);
                    text = text.Replace(word, "");
                }
                Console.WriteLine("Result is: {0}", text);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch
            {
                throw;
            }
        }
        
    }
}
