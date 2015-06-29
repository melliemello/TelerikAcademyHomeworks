using System;

namespace _09_Exchange_Variables
{
    class ExchangeVariables
    {
        static void Main()
        {
            byte a = 5;
            byte b = 10;
            byte temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Variable A is now " + a + " instead of 5");
            Console.WriteLine("Variable B is now " + b + " instead of 10");
        }
    }
}
