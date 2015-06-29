using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>
            {
                new DepositAccount(new Individual("Petar Petrov"), 1000,0.02),
                new DepositAccount(new Company("CompanyLTD"), 15000,0.02),
                new DepositAccount(new Individual("Maria Petrova"), 1500,0.05),
                new MortgageAccount(new Company("CompanyLTD"), 50000,0.04),
                new MortgageAccount(new Individual("Maria Petrova"), 35000,0.06),
                new LoanAccount(new Company("CompanyLTD"), 7000,0.08),
                new DepositAccount(new Individual("Maria Petrova"), 1500,0.0012),        
            };

            Bank Investbank = new Bank(accounts);

            MortgageAccount testPersonalAccount = new MortgageAccount(new Individual("Marcheto"), 1200, 0.02);
            Console.WriteLine(testPersonalAccount.CalculateInterest(24)); 

        }





        
    }
}
