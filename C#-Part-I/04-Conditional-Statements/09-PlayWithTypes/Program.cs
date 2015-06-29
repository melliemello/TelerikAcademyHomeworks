using System;

namespace _09_PlayWithTypes
{
    class PlayWithTypes
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:1 --> int, 2 --> double,3 --> string");
            int choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine(ChangeInt());
                    break;
                case 2:
                    Console.WriteLine(ChangeDouble());
                    break;
                case 3:
                    Console.WriteLine(ChangeString());
                    break;
                default:
                    Console.WriteLine("Plesae enter a valid choice from 1 to 3");
                    break;
            }
        }

        static double ChangeDouble()
        {
            Console.WriteLine("enter a double:");
            double number = Double.Parse(Console.ReadLine());
            return ++number;
        }

        static int ChangeInt()
        {
            Console.WriteLine("enter an integer:");
            int number = Int32.Parse(Console.ReadLine());
            return ++number;
        }

        static string ChangeString()
        {
            Console.WriteLine("enter a string:");
            string text = Console.ReadLine();
            return text + "*";
        }
    }
}
