using System;

namespace _04_Zeroies_And_Ones
{
    class Program
    {
        static void Main()
        {
            long number = Int64.Parse(Console.ReadLine());
            string byteNumber = Convert.ToString(number, 2);
            if (byteNumber.Length > 16)
            {
                byteNumber = byteNumber.Substring(byteNumber.Length - 16);
            }
            byteNumber = byteNumber.PadLeft(16, '0');
            string[] zero = new string[] { "###", "#.#", "#.#", "#.#", "###" };
            string[] one = new string[] { ".#.", "##.", ".#.", ".#.", "###" };
 
            for (int i = 0; i < 5; i++ )
            {
                for (int j = 0; j < 16; j++ )
                {
                    if (byteNumber[j].ToString() == "0")
                    {
                        Console.Write(zero[i]);
                    }
                    else
                    {
                        Console.Write(one[i]);
                    }
                    if(j != 15)
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
