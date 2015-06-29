using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Signed_Short
{
    class SignedShort
    {
        static void Main()
        {
            Console.WriteLine("Enter a binary number to convert to decimal:");
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(ToBinary(number));
            
        }

        static string ToBinary(short number)
        {
            StringBuilder result = new StringBuilder();
            if (number >= 0)
            {
                while (number > 0)
                {
                    result.Insert(0, number % 2);
                    number /= 2;
                }
                return result.ToString().PadLeft(16, '0');
                
            }
            else 
            {
                int uresult = 32768 - Math.Abs(number);
                StringBuilder res = new StringBuilder();
                while (uresult > 0)
                {
                    res.Insert(0, uresult % 2);
                    uresult /= 2;
                }


                return "1" + res.ToString().PadLeft(15, '0');
            }
        }


    }
}
