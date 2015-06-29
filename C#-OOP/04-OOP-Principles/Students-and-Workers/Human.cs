using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_Workers
{
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public virtual string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (IsValidName(value))
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("The length of the name should be in the range 2-20 characters" );
                }
            }
        }

        public virtual string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (IsValidName(value))
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("The length of the name should be in the range 2-20 characters");
                }
            }
        }
        private bool IsValidName(string name)
        {
            if (name.Length > 2 && name.Length < 20)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}
