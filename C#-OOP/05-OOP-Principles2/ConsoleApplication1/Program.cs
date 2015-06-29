using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Shape[] list = new Shape[] 
            {
                new Triangle(2,4),
                new Square(5),
                new Triangle(3,4),
                new Rectangle(2,5)
            };

            TestCalculateSurface test = new TestCalculateSurface(list);
            Console.WriteLine("Test result: {0}", test.TestPassed ? "SUCCESS!": "TEST FAILED");
        }
    }
}
