using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        private List<Account> accounts;

        public Bank(List<Account> accounts)
        {
            this.Accounts = accounts;
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
            set
            {
                this.accounts = value;
            }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
        }
    }
}
