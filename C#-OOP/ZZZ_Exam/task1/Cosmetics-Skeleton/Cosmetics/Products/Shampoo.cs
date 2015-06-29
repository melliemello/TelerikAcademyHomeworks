using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Shampoo:Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            :base(name,brand, price,gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set
            {
                if (value > 0)
                {
                    this.milliliters = value;
                }
            }
        }

        public override decimal Price
        {
            get
            {
                decimal pr = base.Price;
                return base.Price * this.milliliters;
            }
            protected set
            {
                base.Price = value;
            }
        }

        public UsageType Usage
        {
            get { return this.usage; }
            set
            {
                Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Usage"));
                this.usage = value;
            }
        }

        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(String.Format("  * Price: ${0}", this.Price));
            result.AppendLine(String.Format("  * For gender: {0}", this.Gender));
            result.AppendLine(String.Format("  * Quantity: {0} ml", this.Milliliters ));
            result.AppendLine(String.Format("  * Usage: {0}", this.Usage));
            return result.ToString();
        }
    }
}
