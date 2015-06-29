using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Extract_Text_From_HTML
{
    class ExtractText
    {
        static void Main()
        {
            string text = "<html>  <head><title>News</title></head>  <body><p><a href='http://academy.telerik.com'>Telerik Academy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskilful .NET software engineers.</p></body></html>";
            string title = GetContent(text,"<title>", "</title>");
            Console.WriteLine("Title: {0}", title);
            string body = GetContent(text, "<body>", "</body>");
            Console.WriteLine("Body: {0}", RemoveTags(body));
        }

        static string GetContent(string text, string openTag, string closingTag)
        {
            int start = text.IndexOf(openTag) + openTag.Length;
            int len = text.IndexOf(closingTag) - start;
            return text.Substring(start, len);
        }

        static string RemoveTags(string text)
        {
            int startIndex = 0;
            int endIndex = 0;
            while((startIndex = text.IndexOf("<", startIndex)) >= 0)
            {
                if((endIndex = text.IndexOf(">", startIndex)) >= 0) 
                {
                    text = text.Replace(text.Substring(startIndex, endIndex - startIndex+1),"");
                }
            }
            return text;
        }
    }
}
