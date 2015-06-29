using System;


namespace _03_X___Expression
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine().Trim('=');
            int length = expression.Length;            
            Console.WriteLine("{0:F2}",CalculateExpression(expression));
        }

        static double CalculateExpression(string subExpression)
        {
            int len = subExpression.Length;
            double res = Char.IsDigit(subExpression[0]) ? double.Parse(subExpression[0].ToString()) : CalculateExpression(subExpression.Substring(0, subExpression.IndexOf(")", 0)));
            double b = 0;

         for (int i = 1 ; i <= len - 2; i+=2 )
            {

             if ( i == 1 && subExpression[0].ToString() == "(")
             {
                 i = subExpression.IndexOf(")") + 1;
             }

             string operation = subExpression[i].ToString();

             if (subExpression[i + 1].ToString() != "(")
             {
                 b = double.Parse(subExpression[i + 1].ToString());
             }
             else if (subExpression[i + 1].ToString() == "(")
             {
                 int start = i + 2;
                 int end = subExpression.IndexOf(")", start) - start;
                 b = CalculateExpression(subExpression.Substring(start, end));
                 i = subExpression.IndexOf(")", start) - 1;
             }


                if(operation == "-")
                {
                    res = res - b;
                }

                if (operation == "+")
                {
                    res = res + b;
                }

                if (operation == "*")
                {
                    res = res * b;
                }

                if (operation == "/")
                {
                    res = res / b;
                }
            }
            return res;
        }
    }
}
