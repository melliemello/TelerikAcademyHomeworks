using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    public class Teacher:Human
    {

        public Teacher(string name)
        {
            this.Name = name;
        }

        public Teacher(string name, List<Discipline> disciplines)
        {
            this.Name = name;
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines { get; private set; }

        public void AddDiscipline(Discipline discipline)
        {
            if (!this.Disciplines.Contains(discipline))
            {
                this.Disciplines.Add(discipline);
            }
            else
            {
                Console.WriteLine("This teacher already teaches this discipline");
            }
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (!this.Disciplines.Contains(discipline))
            {
                this.Disciplines.Remove(discipline);
            }
            else
            {
                Console.WriteLine("The discipline was not found");
            }
        }
    }
}
