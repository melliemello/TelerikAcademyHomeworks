using System;

namespace _04__Eggcelent
{
    class Program
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int width = (3 * n) + 1;
            int height = 2 * n;
            int middleLength = n-1;
            string middle;
            int outer = (width - middleLength)/2;
            bool desc = true;

            for (int i = 0; i < height; i++)
            {
                if (outer < 1)
                {
                    outer = 1;
                }
                if (i == 0 || i == height-1)
                {
                    middle = new String('*', n-1);
                }
                else if(i == n-1)
                {
                    outer = 1;
                    middleLength = width - 2;
                    middle = "*" + ribbon((width - 4)/2) + "@*";
                    
                }
                else if (i == n)
                {
                    outer = 1;
                    middleLength = width - 2;
                    middle = "*." + ribbon((width - 4) / 2) + "*";
                    desc = false;
                }
                else
                {
                    middle = "*" + new String('.', middleLength-2) + "*";
                }
                string line = new String('.',outer) + middle + new String('.',outer);

                if (desc)
                {
                    outer-= 2;
                    middleLength += 4;
                }
                else
                {
                    outer+=2;
                    middleLength -= 4;
                }
                
                Console.WriteLine(line);

            }
        
        }

        public static string ribbon(int repetition)
        {
            string temp = "";
            for (int i = 0; i < repetition; i++ )
            {
                temp += "@.";
            }
            return temp;
        }
    }
}
