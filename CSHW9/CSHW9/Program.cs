using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW9
{
    public struct Point
    {
        public double X
        {
            get;
        }

        public double Y
        {
            get;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow((point.X - this.X), 2) + Math.Pow((point.Y - this.Y), 2));
        }
        public override string ToString()
        {
            return ($"({X};{Y})");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            for (int i = 0; i < 3; i++)
            {
                Point a = new Point((i + 1), i * 3);
                Point b = new Point((i + 1) * 2, i * 2);
                Point c = new Point((i + 1) * 2, i);


                triangles.Add(new Triangle(a, b, c));
            }

            foreach (var triange in triangles)
            {
                triange.Print();
            }
           
            Console.ReadKey();
        }       
    }
}
