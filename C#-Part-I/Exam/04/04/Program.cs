using System;


namespace _04
{
    class Program
    {
        static void Main()
        {
            int n = 5;//int.Parse(Console.ReadLine());
            int d = 1;//int.Parse(Console.ReadLine());
            int  height = (2 * n) + 1;
            int times = ((height - (d+2)) / 2) - 1;
            int middleLen = 3 + (times * 2);
            int crossLen = (height - middleLen) / 2;
            string crossLeft = "";
            string crossRight = "";
            int availableSpace = height - (2*crossLen) - middleLen;
            int outerLen = 0;
            string mid;

            

            for (int i = 0; i < height; i++ )
            {
                
                if (crossLen < (d + 1))
                {
                    crossLeft = new String('#', crossLen) ;
                    crossRight = new String('#', crossLen) ;
                }
                else
                {
                    crossLeft = "\\" + new String('#', crossLen-1);
                    crossRight = new String('#', crossLen-1) + "/";
                }

                if (middleLen == 1 )
                {
                    mid = "X";
                    middleLen = 1;
                }
                else
                {
                    mid = "\\" + new String('.', middleLen-2) + "/";
                }

                if (availableSpace >= 2)
                {
                    outerLen = availableSpace / 2;
                }

                Console.WriteLine(new String('.', outerLen) + crossLeft + mid + crossRight + new String('.', outerLen));
                if(crossLen < (d+2)){
                    crossLen++;
                }
                middleLen-=2;

                availableSpace = height - (2*crossLen) - (middleLen);

            }

            

        }
    }
}
