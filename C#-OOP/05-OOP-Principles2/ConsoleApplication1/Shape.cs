using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get{return this.width;}
            set
            {
                if (IsValidSide(value))
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size of any side should be greater than 0");
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (IsValidSide(value))
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size of any side should be greater than 0");
                }
            }
        }

        public abstract double CalculateSurface();
        private bool IsValidSide(double side)
        {
            if (side > 0)
            {
                return true;
            }
            return false;
        }
    }
}
