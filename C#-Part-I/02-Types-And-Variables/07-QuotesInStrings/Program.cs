using System;

namespace _7QuotesInStrings
{
    class _7QuotesInStrings
    {
        static void Main()
        {
            string verbatimString = @"The ""use"" of quotations causes difficulties.";
            string quotedString = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("verbatim string: " + verbatimString);
            Console.WriteLine("quoted  string: " + quotedString);
        }
    }
}
