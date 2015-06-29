using System;


    class Program
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            string numberToCheck;

            string sByte = ConvertToByte(s);
            string pattern = sByte.Substring(24);

            for (int i = 0; i < n; i++ )
            {
                int temp = Int32.Parse(Console.ReadLine());
                numberToCheck = ConvertToByte(temp);
                for (int j = 0; j < 29 - 4; j++ )
                {
                    if(numberToCheck.Substring(j, 5) == pattern)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        public static string ConvertToByte(int number)
        {
            string sByte = Convert.ToString(number, 2).PadLeft(29, '0');

            int len = sByte.Length;
            if (len > 29)
            {
                sByte = sByte.Substring(len - 29);
            }

            return sByte;
        }
    }

