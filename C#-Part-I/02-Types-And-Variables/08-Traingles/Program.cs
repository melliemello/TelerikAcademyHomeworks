using System;


namespace _08_Traingles
{
    class Triangles
    {
        static void Main()
        {
            char copy = '@';
            int length = 9;
            int midLength = length / 2;
            string outer = new String(' ', length/2 - 1 );
            string fistLine = outer + copy + outer;
            string lastLine = "@ ";
            string inner;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(fistLine);
            
            for(int i = 1,j=3; i < 3; i++,j--) 
            {
                outer = new String(' ', j-1);
                inner = new String(' ' , i*2-1);
                Console.WriteLine(outer + copy.ToString() + inner + copy.ToString() + outer);
            }
            while (midLength > 0)
            {
                Console.Write(lastLine);
                midLength--;
            }
        }
    }
}
