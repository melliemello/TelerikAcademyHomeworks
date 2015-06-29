using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16_Students
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, int FN, int groupNumber, string tel, string email, List<byte> grades)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = FN;
            this.GroupNumber = groupNumber;
            this.Tel = tel;
            this.Email = email;
            this.Grades = grades;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int FN { get; private set; }
        public int GroupNumber { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public List<byte> Grades { get; private set; }

        public override string ToString()
        {
            StringBuilder gradesString = new StringBuilder("Grades:");
            foreach (byte grade in this.Grades)
            {
                gradesString.Append(grade);
                gradesString.Append(" ");
            }
            return 
                this.FirstName + " " 
                + this.LastName +" " 
                + this.Age + " " 
                + this.FN + " "
                + this.GroupNumber + " "
                + this.Tel + " "
                + this.Email + " "
                + gradesString;
        }
    }
}
