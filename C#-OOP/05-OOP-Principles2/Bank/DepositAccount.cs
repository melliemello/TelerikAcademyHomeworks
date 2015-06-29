using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DepositAccount:Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, double balance, double interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }

        public override double CalculateInterest(int months)
        {
            if(this.Balance > 0 && this.Balance <=1000)
            {
                return 0;
            }
            return this.Interest * this.Balance * months;
        }

        public void Deposit(double sum)
        {
            this.Balance += sum;
        }

        public void Withdraw(double sum)
        {
            this.Balance -= sum;
        }
    }
}
