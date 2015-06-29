using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    public class Discipline:CommentableObject
    {
        private string name;
        private int lectures;
        private int exercises;

        public Discipline(string name, int lectures, int exercices)
        {
            this.Name = name;
            this.Exercices = exercices;
            this.Lectures = lectures;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (IsValidName(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The length of the name should be in the range 2-100 characters");
                }
            }
        }

        public int Lectures
        {
            get { return this.lectures; }
            private set
            {
                if (isValidCount(value))
                {
                    this.lectures = value;
                }
                else
                {
                    throw new ArgumentException("The number of lectures should be in the range [2-52]");
                }
            }
        }

        public int Exercices
        {
            get { return this.exercises ; }
            private set
            {
                if (isValidCount(value))
                {
                    this.exercises = value;
                }
                else
                {
                    throw new ArgumentException("The number of exercises should be in the range [2-52]");
                }
            }
        }


        private bool IsValidName(string name)
        {
            if (name.Length > 2 && name.Length < 100)
            {
                return true;
            }
            return false;
        }

        public bool isValidCount(int number)
        {
            if (number > 0 && number < 52)
            {
                return true;
            }
            return false;
        }
    }
}
