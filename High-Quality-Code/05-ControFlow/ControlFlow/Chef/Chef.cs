using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Chef
{
    public class Chef
    {
        private ICookingFactory cookingFactory;

        public Chef(ICookingFactory factory)
        {
            cookingFactory = factory;
        }

        public Bowl Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();

            PrepareVegetable(potato);
            PrepareVegetable(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);

            return bowl;
        }

        private Vegetable PrepareVegetable(Vegetable vegetable)
        {
            Cut(vegetable);
            Peal(vegetable);

            return vegetable;
        }

        private Bowl GetBowl()
        {
            return cookingFactory.GetBowl(); 
        }

        private Carrot GetCarrot()
        {
            return cookingFactory.GetCarrot();
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.IsCut = true;
        }

        private void Peal(Vegetable vegetable)
        {
            vegetable.IsPealed = true;
        }
        
        private Potato GetPotato()
        {
            return cookingFactory.GetPotato();
        }
    }
}
