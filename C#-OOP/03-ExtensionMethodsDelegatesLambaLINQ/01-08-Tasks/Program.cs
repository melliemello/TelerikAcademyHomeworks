using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_Tasks
{
    class Program
    {
        static void Main()
        {
            //Task 1
            Console.WriteLine("The Substring [0,3] for {0} is {1}","Some text", new StringBuilder("Some text").Substring(0,3));

            //Task 2            
            //Task2 -> Sum Strings excpetion
            //List<string> testStringList = new List<string> { "sd", "fd" };
            //testStringList.Sum();
            //Task2 -> Sum Numerics
            List<int> testIntList = new List<int> { 1,2,3};
            Console.WriteLine("Sum is:{0}", testIntList.Sum());
            //Task2 -> Product Numerics
            Console.WriteLine("Product is:{0}",testIntList.Product()); 
            //Task2 -> Average
            Console.WriteLine("Average is:{0}",testIntList.Average());
            //Task2 -> Min
            Console.WriteLine("Min is:{0}", testIntList.MinExt());
        }
    }
}
