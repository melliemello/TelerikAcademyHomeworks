using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    public class Class:CommentableObject
    {
        private string id;
        private static List<string> identificators = new List<string>();
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(string id, List<Student> students, List<Teacher> teachers)
        {
            this.students = students;
            this.teachers = teachers;
            this.ID = id;
        }

        public string ID {
            get {return this.id; }
            private set
            {
                if (!identificators.Contains(value) && IsValidStringID(value))
                {
                    this.id = value;
                    identificators.Add(value);
                }
                else
                {
                    throw new ArgumentException("the id of the class shoud be provided in this format: 2a");
                }
            }
        }

        private bool IsValidStringID(string id)
        {
            if (id.Length > 1 && id.Length < 3)
            {
                return true;
            }
            return false;
        }

    }
}
