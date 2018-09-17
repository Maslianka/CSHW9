using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW9
{
    public class Triangle
    {
        public Point Point1
        {
            get;
        }
        public Point Point2
        {
            get;
        }
        public Point Point3
        {
            get;
        }

        public Triangle()
        {
        }

        public Triangle(Point point1, Point point2, Point point3)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Point3 = point3;
        }

        public double Perimiter()
        {
            return (Point1.Distance(Point2) + Point2.Distance(Point3) + Point3.Distance(Point1));
        }

        public double Square()
        {
            return (Point2.Distance(Point3) * (Point1.Y - Point2.Y)) / 2;
        }

        public void Print()
        {
            Console.WriteLine("Point A " + Point1.ToString() + ", Point B " + Point2.ToString() + ", Point C " + Point3.ToString());
        }
    }
}
