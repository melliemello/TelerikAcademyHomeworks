using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.ImproveCohesionAndCoupling
{
    internal class Cuboid
    {
        private double width;
        private double height;
        private double depth;

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width 
        {
            get 
            { 
                return this.width; 
            }

            set 
            {
                Validator.ValidateNumberGreaterThanZero(value, "Cuboid width should be greater than zero");
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
                Validator.ValidateNumberGreaterThanZero(value, "Cuboid height should be greater than zero");
                this.height = value;
            }
        }

        public double Depth
        {
            get 
            { 
                return this.depth; 
            }

            set 
            {
                Validator.ValidateNumberGreaterThanZero(value, "Cuboid depth should be greater than zero");
                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.width * this.height * this.depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = GeometryHelper.CalcDistance3D(0, 0, 0, this.width, this.height, this.depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = GeometryHelper.CalcDistance2D(0, 0, this.width, this.height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = GeometryHelper.CalcDistance2D(0, 0, this.width, this.depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = GeometryHelper.CalcDistance2D(0, 0, this.height, this.depth);
            return distance;
        }
    }
}
