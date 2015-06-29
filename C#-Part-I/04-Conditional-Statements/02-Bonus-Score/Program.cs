using System;


namespace _02_Bonus_Score
{
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("Enter the score:");
            int score = Int32.Parse(Console.ReadLine());
            if(score < 0 || score > 9)
            {
                Console.WriteLine("Invalid score");
            }
            else if(score >=1 && score <= 3)
            {
                Console.WriteLine("Score:{0}", score * 10);
            }
            else if(score >=4 && score <= 6)
            {
                Console.WriteLine("Score:{0}", score * 100);
            }
            else if(score >=7 && score <= 9)
            {
                Console.WriteLine("Score:{0}", score * 1000);
            }
            
        }
    }
}
