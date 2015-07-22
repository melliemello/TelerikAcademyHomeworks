using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityMethods.Methods
{
    internal class Student : IStudent
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(IStudent other)
        {
            bool isOlder = this.GetAge() - other.GetAge() > 0;
            return isOlder;
        }

        public int GetAge()
        {
            string age = this.OtherInfo.Substring(this.OtherInfo.Length - 10);
            int parsedAge;
            int.TryParse(age, out parsedAge);

            if (parsedAge == 0)
            {
                throw new Exception("Age is not valid");
            }

            return parsedAge;
        }
    }
}
