using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Singing_Cats
{
    class Program
    {
        static void Main()
        {
            int numberCats = int.Parse(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            int numberSongs = int.Parse(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            List<string> cats = new List<string>();
            for(int i = 0; i < numberCats; i++)
            {
               cats.Add((i+1).ToString());
            }

            List<string>[] songs = new List<string>[numberSongs];
            for (int i = 0; i < numberSongs; i++ )
            {
                songs[i] = new List<string>();
            }

            string input = String.Empty;
            string[] line;
            while((input=Console.ReadLine()) != "Mew!")
            {
                line = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string cat = line[1];
                int song = int.Parse(line[4]) - 1;                
                songs[song].Add(cat);
            }

            songs = songs.OrderBy(item => item.Count).Reverse().ToArray();
            int len = songs.Length - 1;
            int counter = 0;
            for (int s = 0; s < songs.Length; s++ )
            {
                bool sing = false;
                if( cats.Count == 0)
                {
                    break;
                }

                for (int c = 0; c < cats.Count; c++ )
                {
                    
                    if(songs[s].Contains(cats[c]))
                    {
                        cats.Remove(cats[c]);
                        c--;
                        sing = true;
                    }
                }

                if(sing == true)
                {
                    counter++;
                }
            }

            if (cats.Count == 0 )
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("No concert!");
            }
        }
    }
}
