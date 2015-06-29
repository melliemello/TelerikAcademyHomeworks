using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Toothpaste:Product, IToothpaste
    {
        private List<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<String> ingredients)
            :base(name,brand,price,gender)
        {
            this.Ingredients = string.Join(",", ingredients.ToArray());
        }

        public string Ingredients
        {
            get 
            {
               return PrintIngredients(this.ingredients);
            }

            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Ingredients"));
                string[] ingredients;
                this.ingredients = new List<string>();
                ingredients = value.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string ingredient in ingredients)
                {
                    Validator.CheckIfStringIsNullOrEmpty(ingredient, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));
                    Validator.CheckIfStringLengthIsValid(ingredient, 12, 4, String.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", 4, 12));
                    this.ingredients.Add(ingredient);
                }
            }
        }

        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.Print().TrimEnd('\n','\r'));
            result.AppendLine(String.Format("  * Ingredients: {0}", PrintIngredients(this.ingredients)));
            return result.ToString();
        }

        private string PrintIngredients(List<string> list)
        {
            StringBuilder result = new StringBuilder();
            foreach (string ingr in list)
            {
                result.Append(String.Format("{0}, ", ingr));
            }

            return result.ToString().TrimEnd(',',' ');
        }
    }
}
