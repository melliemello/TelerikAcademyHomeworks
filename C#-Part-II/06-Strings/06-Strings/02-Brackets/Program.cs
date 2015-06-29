using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Brackets
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an expression with brackets:");
            string expression = Console.ReadLine();
            Console.WriteLine(bracketsAreCorrect(expression));
        }

        static bool bracketsAreCorrect(string expression)
        {

            int lastClosed = 0;
            int lastOpen = 0;
            for (int i = 0; i < expression.Length;i++ )
            {
                if(expression[i] == '(')
                {
                    lastClosed = expression.IndexOf(')', lastClosed + 1);
                    if (lastClosed < 0 || lastClosed < i)
                    {
                        return false;
                    }
                    else 
                    {
                        lastClosed++;
                    }
                }
            }
            if (expression.IndexOf("(") < expression.IndexOf(")"))
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
    }
}
