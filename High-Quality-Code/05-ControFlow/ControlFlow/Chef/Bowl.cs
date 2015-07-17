using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Chef
{
    internal class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }

        public List<Vegetable> Ingredients { get; set; }

        public void Add(Vegetable vegetable)
        {
            this.Ingredients.Add(vegetable);
        }
    }
}
