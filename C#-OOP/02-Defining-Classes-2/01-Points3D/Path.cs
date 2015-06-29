using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Points3D
{
    class Path
    {
        private List<Point3D> pathList;

        public Path()
        {
            this.pathList = new List<Point3D>();
        }

        public List<Point3D> All
        {
            get
            {
                return this.pathList;
            }
        }

        public Point3D this[int i]
        {
            get
            {
                return this.pathList[i];
            }
        }

        public void AddPoint(Point3D point)
        {
            this.pathList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pathList.Remove(point);
        }

        public int Count
        {
            get { return this.pathList.Count; }
        }
    }
}
