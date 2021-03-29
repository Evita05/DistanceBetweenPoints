using System;

namespace DistanceBwTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 2;
            int z1 = 3;
            int x2 = 4;
            int y2 = 5;
            int z2 = 6;

            Point3D p1 = new Point3D(x1, y1, z1);
            Point3D p2 = new Point3D(x2, y2, z2);

            double d2 = p1.dist2D(p2);
            double d3 = p1.dist3D(p2);

            Point2D p = new Point2D(0, 0);
            p.printDistance(d2);
            p = p1;
            p1.printDistance(d3);
        }
    }

    public class Point2D
    {
        public double x, y;
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double dist2D(Point2D p)
        {
            double distance = Math.Sqrt(Math.Pow((p.x - x), 2) + Math.Pow((p.y - y), 2));
            return distance;
        }

        public void printDistance(double d)
        {
            Console.WriteLine("2D distance = " + (int)Math.Ceiling(d)); 
        }
    }

    public class Point3D : Point2D
    {
        double z;
        public Point3D(double x, double y,double z) : base(x,y)
        {
            this.z = z;
        }

        public double dist3D(Point3D p)
        {
            double distance = Math.Sqrt(Math.Pow((p.x - x), 2) + Math.Pow((p.y - y), 2 + Math.Pow((p.z - z), 2)));
            return distance;
        }

        public new void printDistance(double d)
        {
            Console.WriteLine("3D distance = " + (int)Math.Ceiling(d));
        }
    }
}
