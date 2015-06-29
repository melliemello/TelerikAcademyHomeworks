using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Account
    {
        private double interest;
        private double balance;
        private Customer customer;

        public double Interest
        {
            get { return this.interest; }
            protected set
            {
                if (IsValidInterestRate(value))
                {
                    this.interest = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("the intereset should be a positive number");
                }
            }
        }

        public Customer Customer
        {
            get { return this.customer; }
            protected set { this.customer = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public abstract double CalculateInterest( int months);

        private bool IsValidInterestRate(double interest)
        {
            if (interest >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
