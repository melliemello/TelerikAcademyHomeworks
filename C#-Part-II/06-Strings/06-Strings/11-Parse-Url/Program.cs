using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Parse_Url
{
    class Program
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            Dictionary<string,string> parsedUrl = ParseUrl(url);
            foreach(KeyValuePair<string, string> entry in  parsedUrl )
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
        }

        static Dictionary<string, string> ParseUrl(string url)
        {
            Dictionary<string, string> urlData = new Dictionary<string, string>();
            int startIndex = 0;
            int endIndex = 0;
            if((endIndex = url.IndexOf("://")) > 0)
            {
                urlData.Add("Protocol", url.Substring(0, endIndex - startIndex));
                startIndex = endIndex + 3;          

            }
            if ((endIndex = url.IndexOf("/", startIndex)) > 0)
            {
                urlData.Add("Server", url.Substring(startIndex, endIndex - startIndex));
                startIndex = endIndex + 1;
            }
            if ((endIndex = url.IndexOf("/", startIndex)) > 0)
            {
                urlData.Add("Resource", url.Substring(startIndex));
            }
            return urlData;

        }
        

    }
}
