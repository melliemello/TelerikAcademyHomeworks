using System;
using System.Collections.Generic;


namespace _06_Binary_To_Hex
{
    class BinaryToHex
    {
        static void Main()
        {
            Console.WriteLine("Enter a binary number to convert to hexadecimal");
            string hexNumber = Console.ReadLine();
            
            Console.WriteLine(ToHex(hexNumber));
            


        }

        static string ToHex(string binary)
        {
            int padding = 4 * (int)Math.Ceiling((double)binary.Length / 4);
            binary = binary.PadLeft(padding, '0');
            string result = "";
            for (int i = 0; i < binary.Length - 3; i += 4)
            {
                string currentNumber = binary.Substring(i, 4);
                switch (currentNumber)
                {
                    case "1010":
                        result += "A";
                        break;
                    case "1011":
                        result += "B";
                        break;
                    case "1100":
                        result += "C";
                        break;
                    case "1101":
                        result += "D";
                        break;
                    case "1110":
                        result += "E";
                        break;
                    case "1111":
                        result += "F";
                        break;
                    case "0000":
                        result += "0";
                        break;
                    case "0001":
                        result += "1";
                        break;
                    case "0010":
                        result += "2";
                        break;
                    case "0011":
                        result += "3";
                        break;
                    case "0100":
                        result += "4";
                        break;
                    case "0101":
                        result += "5";
                        break;
                    case "0110":
                        result += "6";
                        break;
                    case "0111":
                        result += "7";
                        break;
                    case "1000":
                        result += "8";
                        break;
                    case "1001":
                        result += "9";
                        break;

                }                
            }
            return result;
            
        }

    }
}
