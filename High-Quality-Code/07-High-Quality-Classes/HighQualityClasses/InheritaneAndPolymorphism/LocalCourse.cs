using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.InheritaneAndPolymorphism
{
    internal class LocalCourse : Course
    {
        private const string InvalidLabNameExceptionMessage = "Lab name cannot be null or empty.";
        private string lab = null;

        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get 
            { 
                return this.lab; 
            }

            set
            {
                Validator.ValidateNonEmptyString(value, InvalidLabNameExceptionMessage);
            }
        }

        public override string ToString()
        {
            string basicDetails = base.ToString();
            StringBuilder result = new StringBuilder(basicDetails);

            if (this.lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
