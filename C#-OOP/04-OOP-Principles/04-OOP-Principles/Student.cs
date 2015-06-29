using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    public class Student:Human
    {
        private static int counter = 0;  

        public Student(string name)
        {
            this.Name = name;
            this.ID = counter;
            counter++;
        }
        public int ID { get; private set; }

    }
}
