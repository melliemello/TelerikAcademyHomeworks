using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Chef
{
    internal class CookingFactory : ICookingFactory
    {
        public Potato GetPotato()
        {
            return new Potato();
        }

        public Carrot GetCarrot()
        {
            return new Carrot();
        }

        public Bowl GetBowl()
        {
            return new Bowl();
        }
    }
}
