//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
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
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string text = "";
            char[] separators = new char[] { ' ', '\n', ',' };


            try
            {
                using (StreamReader wordsFile = new StreamReader("../../words.txt"))
                {
                    words = wordsFile.ReadToEnd().ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

                }
                using (StreamReader textFile = new StreamReader("../../text.txt"))
                {
                    text = textFile.ReadToEnd();
                }
                foreach (string word in words)
                {
                    int foundIndex = -1;
                    while((foundIndex = text.IndexOf(word, foundIndex+1)) >= 0)
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount.Add(word,1);
                        }
                    }                    
                }
                
                using(StreamWriter sw = new StreamWriter("../../result.txt"))
                {
                    foreach(KeyValuePair<string,int> entry in wordCount )
                    {
                        sw.WriteLine("{0}: {1}", entry.Key, entry.Value );
                    }
                }
                Console.WriteLine("Success!");
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
