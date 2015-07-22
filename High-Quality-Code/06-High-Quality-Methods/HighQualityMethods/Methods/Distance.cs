using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityMethods.Methods
{
    public class Distance
    {
        public Distance(double distance, bool isHorizontal, bool isVertical)
        {
            this.Value = distance;
            this.IsHorizontal = IsHorizontal;
            this.IsVertical = IsVertical;
        }

        public double Value { get; set; }

        public bool IsHorizontal { get; set; }

        public bool IsVertical { get; set; }
    }
}
