using System;

namespace Homework_6
{
    class Point
    {
        int x { get; set; }

        public Point(int x)
        {
            this.x = x;
        }
        public override string ToString()
        {
            return "x= " + this.x;
        }
    }
    class Circle:Point
    {
        int radius;

        public Circle(int radius, int x):base(x)
        {
            this.radius = radius;
        }
        public override string ToString()
        {
            return base.ToString() + ", radius= " + radius;
        }
    }
    class Cylinder : Circle
    {
        int height;

        public Cylinder(int height, int radius, int x):base(radius, x)
        {
            this.height = height;
        }
        public override string ToString()
        {
            return base.ToString() + ", height= " + height; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cylinder c = new Cylinder(10, 20, 30);
            Console.WriteLine(c.ToString());
        }
    }
}
