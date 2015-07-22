using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.InheritaneAndPolymorphism
{
    internal abstract class Course
    {
        private const string InvalidCourseNameExceptionMessage = "Course name cannot be null or empty.";
        private const string InvalidTeacherNameExceptionMessage = "Teacher name cannot be null or empty.";
        private const string InvalidStudentNameExceptionMessage = "Student name cannot be null or empty.";
        private string name;
        private string teacherName = null;
        private IList<string> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<string>();
        }

        public Course(string name, string teacherName)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.students = new List<string>();
        }

        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name 
        {
            get 
            { 
                return this.name; 
            }

            set
            {
                Validator.ValidateNonEmptyString(value, InvalidCourseNameExceptionMessage);
                this.name = value;
            }
        }

        public string TeacherName
        {
            get 
            { 
                return this.teacherName; 
            }

            set
            {
                Validator.ValidateNonEmptyString(value, InvalidTeacherNameExceptionMessage);
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get 
            { 
                return this.students; 
            }

            set
            {
                for (int i = 0, len = value.Count; i < len; i++)
                {
                    Validator.ValidateNonEmptyString(value[i], InvalidStudentNameExceptionMessage);
                }

                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.name);

            if (this.teacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.teacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.students == null || this.students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.students) + " }";
            }
        }
    }
}
