using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(3);
            list.Add(0);
            list.Add(1);
            list.Add(2);

            //Insert at position 2
            list.InsertAt(2,9);
            Console.WriteLine("The 2nd element is:{0}",list[2]);

            //Find the max value
            Console.WriteLine("Max value is:{0}", list.Max()); 

            //Remove index 2
            list.RemoveAt(2);
            Console.WriteLine(list[2]);
            Console.WriteLine("The 2nd element is:{0}", list[2]);
            //Find the min value
            Console.WriteLine("Min value is:{0}", list.Min()); 

            //Clear the list
            list.Clear();
            Console.WriteLine("The length of the list after it has been cleared:{0}", list.All.Length);


        }
    }
}
