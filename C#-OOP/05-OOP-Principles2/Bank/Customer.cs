using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Customer
    {
        private string name;
                
        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (IsValidName(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The lenght of the name should be in the range [3-50]");
                }
            }
        }

        public abstract int MortgagePromotionalPeriod { get;}
        public abstract int LoanPromotionalPeriod{ get;}

        private bool IsValidName(string name)
        {
            if(name.Length > 2 && name.Length <= 50)
            {
                return true;
            }
            return false;
        }
    }
}
