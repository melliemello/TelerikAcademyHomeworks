using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Chef
{
    internal abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsCut = false;
            this.IsPealed = false;
        }

        public bool IsPealed { get; set; }

        public bool IsCut { get; set; }
    }
}
