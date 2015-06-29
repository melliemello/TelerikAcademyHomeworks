using System;
using System.Collections.Generic;


namespace _05_Binary_To_Hex
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a hexadecimal number to convert to binary:");
            string hex = Console.ReadLine();
            Console.WriteLine(HexToBinary(hex));
        }

        static string HexToBinary(string hex)
        {
            string result="";
            char[] hexArray = hex.ToCharArray();
            for(int i = 0; i < hexArray.Length; i++)
            {
                result += HexDigitToBinary(hexArray[i].ToString()) + " ";
            }
            return result;
        }


        static string HexDigitToBinary(string digit)
        {
            string result = "";
            int decDigit = 0;
            if (int.TryParse(digit, out decDigit))
            {
                return ToBinary(decDigit);
            }
            else
            {
                switch (digit.ToUpper())
                {
                    case "A":
                        result = "1010";
                        break;
                    case "B":
                        result = "1011";
                        break;
                    case "C":
                        result = "1100";
                        break;
                    case "D":
                        result = "1101";
                        break;
                    case "E":
                        result = "1110";
                        break;
                    case "F":
                        result = "1111";
                        break;
                    case "G":
                        result = "10000";
                        break;
                }

                return result;
            }
        }



        static string ToBinary(int number)
        {
            List<string> binary = new List<string>();
            while (number > 0)
            {
                binary.Add((number % 2).ToString());
                double result  = number / 2;
                number = (int)Math.Floor(result);

            }
            binary.Reverse();
            string res = String.Join("", binary);
            return res.PadLeft(4,'0') ;
        }
    }
}
