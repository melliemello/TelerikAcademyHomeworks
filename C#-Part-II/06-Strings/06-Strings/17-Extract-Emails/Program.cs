using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _17_Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string text = "Here is some text with some emails like some_adress@domain.some : the first one is _abc%$@dom.com, the second one is name@abv.bg and so on...";
            string pattern = @"[^ ]+@[a-z]+\.[a-z]+";
            Regex regex = new Regex(pattern);
             List<string> emails = new List<string>();
            Console.WriteLine("Emails:");
            foreach (Match match in regex.Matches(text))
            {
                emails.Add(match.ToString());
                Console.WriteLine(match.ToString());
            }
        }
    }
}
