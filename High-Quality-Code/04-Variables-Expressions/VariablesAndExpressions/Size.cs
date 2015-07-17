namespace VariablesAndExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size objectSize, double rotationAngle)
        {
            double rotationAngleCos = Math.Cos(rotationAngle);
            double rotationAngleSin = Math.Sin(rotationAngle);
            double rotationCosAbs = Math.Abs(rotationAngleCos);
            double rotationSinAbs = Math.Abs(rotationAngleSin);

            double newWidth = (rotationCosAbs * objectSize.Width) + (rotationSinAbs * objectSize.Height);
            double newHeight = (rotationSinAbs * objectSize.Width) + (rotationCosAbs * objectSize.Height);
            return new Size(newWidth, newHeight);
        }
    }
}
