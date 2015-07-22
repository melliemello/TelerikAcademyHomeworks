using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.ImproveCohesionAndCoupling
{
    internal class UtilsExamples
    {
        public static void TestFileHelper()
        {
            ////Throws exception
            ////Console.WriteLine(FileHelper.GetFileExtension("example"));
            Console.WriteLine(FileHelper.GetFileExtension("example.pdf"));
            Console.WriteLine(FileHelper.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileHelper.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileHelper.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileHelper.GetFileNameWithoutExtension("example.new.pdf"));
        }

        public static void TestGeometryUtils()
        {
            Console.WriteLine("Distance in the 2D space = {0:f2}", GeometryHelper.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", GeometryHelper.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid cuboid = new Cuboid(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", cuboid.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cuboid.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cuboid.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cuboid.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cuboid.CalcDiagonalYZ());
        }
    }
}
