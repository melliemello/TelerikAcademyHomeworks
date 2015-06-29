using System;

namespace _04_Troll_Diamond
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = (n * 2) + 1; 
            int height = 6 + ((n - 3) / 2) * 3 ;
            int outer = (width - n)/2;
            int middleLength = n;
            string middle;
            bool desc = true;


            for (int i = 0; i < height; i++ )
            {
                if (i == 0 || i == (height - 1))
                {
                    middle = new string('*', middleLength);
                }
                else if( outer == 0)
                {
                    middle = new string('*', middleLength);
                }
                else
                {
                    string inner = new string('.', (middleLength - 3)/2);
                    middle = "*" + inner + "*" + inner + "*";
                    
                }
                
                string line = new string('.', outer) + middle + new string('.', outer);
                Console.WriteLine(line);
                if (desc)
                {
                    outer--;
                    middleLength += 2;
                }
                else
                {
                    outer++;
                    middleLength -= 2;
                }

                if(outer == 0)
                {
                    desc = false;
                }
            }
        }
    }
}
