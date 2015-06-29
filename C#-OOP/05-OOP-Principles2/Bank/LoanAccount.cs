using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class LoanAccount:Account,IDepositable
    {
        public LoanAccount(Customer customer, double balance, double interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }

        public override double CalculateInterest(int months)
        {
            if (months > this.Customer.LoanPromotionalPeriod)
            {
                return this.Interest * this.Balance * (months - this.Customer.LoanPromotionalPeriod);
            }
            else
            {
                return 0;
            }          
            
        }

        public void Deposit(double sum)
        {
            this.Balance += sum;
        }
    }
}
