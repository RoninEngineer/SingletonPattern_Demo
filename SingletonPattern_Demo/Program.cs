using System;

namespace SingletonPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry.Instance.length = 4;
            Geometry.Instance.height = 2;
            Geometry.Instance.radius = 3;

            var rectArea = Geometry.Instance.AreaOfaRectangle();
            var circArea = Geometry.Instance.AreaOfaCircle();
            var triArea = Geometry.Instance.AreaOfATriangle();

            Console.WriteLine($"The area of the rectangle is : {rectArea}");
            Console.WriteLine($"The area of the circle is : {circArea}");
            Console.WriteLine($"The area of the triangle is : {triArea}");
            Console.ReadLine();
        }
    }

    public sealed class Geometry
    {
        private static Geometry instance = null;
        public double radius { get; set; }
        public double length { get; set; }
        public double height { get; set; }


        private Geometry()
        {

        }

        public static Geometry Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Geometry();
                }
                return instance;
            }
        }

        public double AreaOfATriangle()
        {
            return .5 * length * height;
        }

        public double AreaOfaRectangle()
        {
            return length * height;
        }

        public double AreaOfaCircle()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
