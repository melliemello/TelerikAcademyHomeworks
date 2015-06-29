using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Points3D
{
    public struct Point3D
    {
        private static readonly Point3D start = new Point3D(0, 0, 0);
        /*private double x;
        private double y;
        private double z;     */

        public Point3D(double x, double y, double z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public static Point3D Start 
        {
            get{return start;}
        }
        public override string ToString()
        {
            return String.Format("{{{0};{1};{2}}}",this.X,this.Y, this.Z);
        }
    }
}
