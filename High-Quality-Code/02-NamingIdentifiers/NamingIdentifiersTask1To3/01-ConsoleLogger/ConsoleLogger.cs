namespace NamingIdentifiersTask1To3.ConsoleLogger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ConsoleLogger
    {
        public void PrintBooleanValue(bool booleanValue)
        {
            string valueAsString = booleanValue.ToString();
            Console.WriteLine(valueAsString);
        }
    }
}
