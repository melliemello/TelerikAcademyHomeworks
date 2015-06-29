using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    public abstract class Human:CommentableObject
    {
        protected string name;

        public virtual string Name
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
                    throw new ArgumentException("The length of the name should be in the range 2-100 characters" );
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
        public override string ToString()
        {
            return this.name;
        }
    }
}
