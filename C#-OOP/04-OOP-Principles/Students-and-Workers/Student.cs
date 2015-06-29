using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_Workers
{
    public class Student:Human
    {
        private int grade;  

        public Student(string fname, string lname, int grade)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (IsValidGrade(value))
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentException("The grade should be in the range [2-6]");
                }
            }
        }

        private bool IsValidGrade(int grade)
        {
            if(grade < 7 && grade> 1)
            {
                return true;
            }
            return false;
        }

    }
}
