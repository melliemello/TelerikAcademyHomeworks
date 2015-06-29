using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Individual:Customer
    {
        private static readonly int loanPromotionalPeriod = 2;
        private static readonly int mortgagePromotionalPeriod = 12;

        public Individual(string name)
        {
            this.Name = name;
        }

        public override int MortgagePromotionalPeriod
        {
            get { return mortgagePromotionalPeriod; }
        }

        public override int LoanPromotionalPeriod
        {
            get { return loanPromotionalPeriod; }
        }
    }
}
