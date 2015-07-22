using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.ImproveAbstractionAndEnapsulation
{
    internal class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get 
            { 
                return this.width; 
            }

            set 
            {
                Validator.ValidateNumberGreaterThanZero(value, "The width of the rectangle should be greater than 0");
                this.width = value;
            }
        }

        public double Height
        {
            get 
            { 
                return this.height; 
            }

            set
            {
                Validator.ValidateNumberGreaterThanZero(value, "The height of the rectangle should be greater than 0");
                this.height = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
