using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Counter
{
    class StringCounter
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";
            string match = "in";
            int counter = 0;
            

            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == match[0])
                {
                    for(int j = 1, k = i+1; j< match.Length; j++, k++)
                    {
                        if(Char.ToUpper(text[k]) != Char.ToUpper(match[j]))
                        {
                            break;
                        }
                        if(j == match.Length-1)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
