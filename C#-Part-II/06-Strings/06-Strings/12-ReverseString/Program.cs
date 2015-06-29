using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ReverseString
{
    class Program
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string signs =   ".,!-:?;" ;
            Dictionary<int, string> punctuation = new Dictionary<int, string>();
            string[] textArr = text.Split(' ');
            List<string> reversed = new List<string>();

            for (int i = textArr.Length-1; i >=0; i-- )
            {
                int lastIndex = textArr[i].Length - 1;
                if (signs.Contains(textArr[i][lastIndex]))
                {
                    punctuation.Add(i, textArr[i][lastIndex].ToString());
                    reversed.Add(textArr[i].Remove(lastIndex));
                }
                else
                {
                    reversed.Add(textArr[i]);
                }
            }

            if(punctuation.Count != 0)
            {
                foreach (KeyValuePair<int, string> entry in punctuation)
                {
                    reversed[entry.Key] += entry.Value;
                }
            }

            Console.WriteLine(String.Join(" ",reversed.ToArray()));
        }
    }
}
