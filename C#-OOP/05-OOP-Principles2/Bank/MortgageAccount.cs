using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MortgageAccount:Account, IDepositable
    {
        public MortgageAccount(Customer customer, double balance, double interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }

        public override double CalculateInterest(int months)
        {
            double InterestAmount = 0;
            if(this.Customer is Company)
            {
                InterestAmount = Math.Min(this.Customer.MortgagePromotionalPeriod, months) * ((this.Interest * this.Balance) / 2);
            }
            if(months > this.Customer.MortgagePromotionalPeriod)
            {
                InterestAmount += (months - this.Customer.MortgagePromotionalPeriod) * this.Interest * this.Balance;
            }
            return InterestAmount;
        }

        public void Deposit(double sum)
        {
            this.Balance += sum;
        }
    }
}
