using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class TestCalculateSurface
    {
        private bool result;
        public TestCalculateSurface(Shape[] shapes)
        {
            this.Shapes = shapes;
            this.TestPassed = IsValidSurfaceCalculator(shapes);

        }

        public Shape[] Shapes{get;private set;}

        public bool TestPassed { get; private set; }
        private bool IsValidSurfaceCalculator( Shape[] shapes)
        {
            for (int i = 0; i < shapes.Length; i++ )
            {
                try
                {
                    Console.WriteLine("{0} {1} with surface:{2}", shapes[i].GetType(), i , shapes[i].CalculateSurface());
                }
                catch
                {
                    return false;
                }               
            }
            return true;
        }
    }
}
