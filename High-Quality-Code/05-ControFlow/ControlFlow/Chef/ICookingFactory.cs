using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Chef
{
    internal interface ICookingFactory
    {
        public Potato GetPotato();

        public Carrot GetCarrot();

        public Bowl GetBowl();
    }
}
