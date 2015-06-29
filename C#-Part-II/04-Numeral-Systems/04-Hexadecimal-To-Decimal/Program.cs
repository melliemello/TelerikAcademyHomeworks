using System;


namespace _04_Hex_To_Decimal
{
    class HexToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a hexadecimal number to convert to decimal");
            string hexNumber = Console.ReadLine();
            Console.WriteLine(ToDecimal(hexNumber));
        }

        static int ToDecimal(string hex)
        {
            int sum = 0;
            string[] hexArray = Array.ConvertAll<char,string>(hex.ToCharArray(), ch=> ch.ToString());
            for (int i = 0; i < hexArray.Length; i++ )
            {
                int currentDigit = ToDecimalDigit(hexArray[i]);
                sum += currentDigit * (int) Math.Pow(16, hexArray.Length - 1 - i);
            }

            return sum;
        }

        static int ToDecimalDigit(string digit)
        {
            int result = 0;
            if (int.TryParse(digit, out result))
            {
                return result;
            }
            else
            {
                switch (digit.ToUpper())
                {
                    case "A":
                        result = 10;
                        break;
                    case "B":
                        result = 11;
                        break;
                    case "C":
                        result = 12;
                        break;
                    case "D":
                        result = 13;
                        break;
                    case "E":
                        result = 14;
                        break;
                    case "F":
                        result = 15;
                        break;
                    case "G":
                        result = 16;
                        break;
                }
                return result;
            }

        }
    }
}
