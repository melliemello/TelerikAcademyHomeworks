using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_Points3D
{
    static class PathStorage
    {
        public static Path Load(string filePath)
        {
            Path path = new Path();
            try
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    string line;
                    while((line = file.ReadLine()) != String.Empty && line != null)
                    {
                        try
                        {
                            double[] coords = Array.ConvertAll<string, double>(line.Substring(line.IndexOf("{") + 1).Split(new char[]{';','}'}, StringSplitOptions.RemoveEmptyEntries), double.Parse);
                            Point3D point = new Point3D(coords[0], coords[1], coords[2]);
                            path.AddPoint(point);
                        }
                        catch
                        {
                            throw new FormatException(String.Format("Invalid format of coordinates in the file {0}", filePath));
                        }
                        
                    }
                }
            }
            catch(FileNotFoundException)
            {
                throw new FileNotFoundException("File {0} not found", filePath);
            }     
            return path;
        }

        public static void Save(string filePath, Point3D point)
        {
            try
            {
                using (StreamWriter file = File.AppendText(filePath))
                {
                    file.WriteLine("p {{{0};{1};{2}}}", point.X, point.Y, point.Z);
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File {0} not found", filePath);
            }
        }
    }
}
