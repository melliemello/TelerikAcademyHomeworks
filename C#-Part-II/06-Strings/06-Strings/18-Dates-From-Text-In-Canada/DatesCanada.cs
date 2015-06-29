using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _18_Dates_From_Text_In_Canada
{
    class DatesCanada
    {
        static void Main()
        {
            string text = "Here is some text with some date like 14.01.2014 : the first one is 14.1.2014, the second one is 1.04.2015, and so on... 14.4.2016, 14.05.2015, 14/12/2014";
            string pattern = @"[0-3]{1}[1-9]{1}\.[0-1]{1}[0-9]{1}\.[0-9]{4}";
            Regex regex = new Regex(pattern);
            CultureInfo culture = new CultureInfo("en-CA");
            Console.WriteLine("Dates:");
            foreach (Match match in regex.Matches(text))
            {  
                
                try
                {
                    DateTime date = DateTime.ParseExact(match.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine(date.ToString("d", culture)); 
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
