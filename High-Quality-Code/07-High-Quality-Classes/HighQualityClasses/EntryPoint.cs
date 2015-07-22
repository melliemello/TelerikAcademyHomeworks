using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighQualityClasses.ImproveAbstractionAndEnapsulation;
using HighQualityClasses.ImproveCohesionAndCoupling;
using HighQualityClasses.InheritaneAndPolymorphism;

namespace HighQualityClasses
{
    internal class EntryPoint
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("01.uTILS TEST", "----------------------------------------------");
            FiguresExample.TestFigures();

            Console.WriteLine("02.FIGURES TEST", "----------------------------------------------");
            UtilsExamples.TestFileHelper();
            UtilsExamples.TestGeometryUtils();
                
            Console.WriteLine("03.COURSES TEST", "----------------------------------------------");
            CoursesExamples.TestCourse();
        }
    }
}
