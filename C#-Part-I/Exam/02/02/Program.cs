using System;

namespace _02
{
    class Program
    {
        static void Main()
        {
            double secret = Int32.Parse(Console.ReadLine());
            double temp;
            double result;
            string text = Console.ReadLine();
            int len = text.Length;

            for (int i = 0; i < len; i++ )
            {
                if(text[i].ToString() == "@")
                {
                    break;
                }

                if(Char.IsLetter(text[i]))
                {
                     temp = ((int)text[i] * secret) + 1000;
                 }

                else if (Char.IsDigit(text[i]))
                {
                     temp = ((int)text[i] + secret) + 500;
                }
                else
                {
                     temp = (int)text[i] - secret;
                }

                if (i % 2 == 0)
                {
                    result = temp / 100;
                    result = Math.Round(result, 2);
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result = temp * 100;
                    result = Math.Round(result, 2);
                    Console.WriteLine("{0}", result);
                }

                
            }

        }
    }
}


