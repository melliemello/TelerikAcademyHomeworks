using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.ImproveAbstractionAndEnapsulation
{
    internal class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)            
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get 
            { 
                return this.radius; 
            }

            set
            {
                Validator.ValidateNumberGreaterThanZero(value, "The radius of the circle should be greater than 0");
                this.radius = value;
            }
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }
    }
}
