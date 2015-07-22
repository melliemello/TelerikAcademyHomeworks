using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.InheritaneAndPolymorphism
{
    internal class OffsiteCourse : Course
    {
        private const string InvalidTownNameExceptionMessage = "Town name cannot be null or empty.";
        private string town = null;

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : base(name, teacherName, students)
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town 
        {  
            get 
            { 
                return this.town; 
            }

            set 
            {
                Validator.ValidateNonEmptyString(value, InvalidTownNameExceptionMessage);
            }
        }

        public override string ToString()
        {
            string basicDetails = base.ToString();
            StringBuilder result = new StringBuilder(basicDetails);

            if (this.town != null)
            {
                result.Append("; Town = ");
                result.Append(this.town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
