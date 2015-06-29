using System;

namespace _12_Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? intValue = null;
            double? doubleValue = null;
            Console.WriteLine("Integer with null value: " + intValue);
            Console.WriteLine("Double with null value: " + doubleValue);

            intValue = 98979879;
            doubleValue = 98798.8909890909;
            Console.WriteLine("Integer with int value: " + intValue);
            Console.WriteLine("Double with double value: " + doubleValue);
        }
    }
}
