using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Points3D
{
    class Program
    {
        static void Main()
        {
            //Initializing points
            Point3D a = new Point3D(-7,-4, 3);
            Point3D b = new Point3D(17, 6, 2.5);

            //Print points and distance between them
            Console.WriteLine("the distance between point {0} and point {1} is {2}", a,b,DistanceCalculator.Calculate(a,b));

            //Print the static start point
            Console.WriteLine("Start Point is:{0}",Point3D.Start.ToString());

            //Load path from file
            Path path = PathStorage.Load("../../points.txt");
            for (int i = 0; i < path.Count; i++ )
            {
                Console.WriteLine("Point {0}: {1}", i, path[i].ToString());
            }

            //Save new point to file
            PathStorage.Save("../../points.txt", new Point3D(9, 9, 9));
            Console.WriteLine("List after adding a new point {9,9,9}:");
            Path newPath = PathStorage.Load("../../points.txt");
            for (int i = 0; i < newPath.Count; i++)
            {
                Console.WriteLine("Point {0}: {1}", i, newPath[i].ToString());
            }

        }
    }
}
