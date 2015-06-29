using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog:Animal
    {
        private static int MAX_AGE = 20;

        public Dog(string name,int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override int MaxAge { get { return MAX_AGE; } }

        public void ProduceSound()
        {
            Console.WriteLine("Bau! Bau!");
        }
    }
}
