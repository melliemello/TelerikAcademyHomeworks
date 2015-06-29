using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Category:ICategory
    {
        private string name;
        private List<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));
                Validator.CheckIfStringLengthIsValid(value, 15, 2, String.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2,15));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if(!this.products.Contains(cosmetics))
            {
                throw new ArgumentException(String.Format("Product {0} does not exist in category {1}!",cosmetics.Name, this.name) );
            }
            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            //{category name} category – {number of products} products/product in total
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("{0} category - {1} {2} in total", this.name, this.products.Count, this.products.Count == 1 ? "product":"products"));
            if(this.products.Count > 0)
            {
                foreach(IProduct product in this.products.OrderBy(p=> p.Brand).ThenByDescending(p=> p.Price))
                {
                    result.Append(product.Print());
                }
            }

            return result.ToString().TrimEnd('\n','\r');
        }
    }
}
