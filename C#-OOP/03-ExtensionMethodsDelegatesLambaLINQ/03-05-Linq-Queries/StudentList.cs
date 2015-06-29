using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace _03_05_Linq_Queries
{
    class StudentList
    {
        public StudentList(List<Student> list)
        {
            this.All = list;
        }

        public List<Student> All { get; private set;}

        public StudentList FirstBeforeLast()
        {
            var result = from student in this.All
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;
            return new StudentList(result.ToList());
        }

        public StudentList InRange18_24()
        {
            var result = from student in this.All
                         where student.Age < 24 && student.Age > 18
                         select new Student(student.FirstName, student.LastName, null);
            return new StudentList(result.ToList());
        }

        public StudentList OrderByFirstAndLastName()
        {
            var result = this.All.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);
            return new StudentList(result.ToList());
        }

        public StudentList OrderByFirstAndLastNameLINQ()
        {
            var result = from student in this.All
                         orderby student.FirstName, student.LastName
                         select student;
            return new StudentList(result.ToList());
        }
        

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach(Student student in this.All)
            {                
                foreach (PropertyInfo prop in student.GetType().GetProperties())
                {
                    try
                    {
                        result.Append(String.Format("{0} = {1}", prop.Name, prop.GetValue(student, null).ToString()));
                        result.Append(", ");
                    }
                    catch (NullReferenceException)
                    {                        
                    }                    
                }
                result.Append(Environment.NewLine );
            }
            return result.ToString();
        }
        
    }
}
