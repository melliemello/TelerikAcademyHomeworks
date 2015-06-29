using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public abstract class Product:IProduct
    {
        //TODO: EXCTRACT CONSTANTS
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender )
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty( value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty,value));
                Validator.CheckIfStringLengthIsValid(value,10,3, String.Format(GlobalErrorMessages.InvalidStringLength, "Product name",3,10 ));
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));
                Validator.CheckIfStringLengthIsValid(value, 10,2, String.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10));
                this.brand = value;
            }
        }

        public virtual decimal Price
        {

            get { return this.price; }
            protected set
            {
                Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Price"));
                if(value > 0)
                {
                    this.price = value;
                }
            }
        }

        public Common.GenderType Gender 
        {
            get { return this.gender; }
            set
            {
                Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Gender"));
                this.gender = value;
            }
        }

        public virtual string Print()
        {

            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("- {0} - {1}:", this.brand, this.name));
            result.AppendLine(String.Format("  * Price: ${0}", this.price));
            result.AppendLine(String.Format("  * For gender: {0}", this.gender));
            return result.ToString();

        }
    }
}
