//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
using System;
using System.Linq;

namespace _03_PlayCards
{
    class Program
    {
        static void Main()
        {
            string[] cards = new string[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            Console.Write("Enter a character to check:");
            string character = Console.ReadLine();
            string result;
            if (cards.Contains(character))
            {
                result = "yes";
            }
            else{
                result="no";
            }
            Console.WriteLine("Valid card sign? {0}", result);
        }
    }
}
