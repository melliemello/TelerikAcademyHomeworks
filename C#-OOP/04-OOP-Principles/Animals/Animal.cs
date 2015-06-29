using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private Gender gender;
        private int age;

        public string Name 
        { 
            get{return this.name;}
            set
            {
                if(isValidName(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The length of the name shoud be in the range[2-20]");
                }
            }
        }

        public Gender Gender { get; protected set; }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (isValidAge(value))
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("The age should be in the range[2-{0}]", MaxAge));
                }
            }
        }

        public abstract int MaxAge { get; }

        public static double AverageAge(Animal[] list)
        {
            return list.Average(animal => animal.Age);
        }

        private bool isValidName(string name)
        {
            if(name.Length > 1 && name.Length <  MaxAge)
            {
                return true;
            }
            return false;
        }

        private bool isValidAge(int age)
        {
            if (age > 0 &&  age < 20)
            {
                return true;
            }
            return false;
        }
        


    }
}
