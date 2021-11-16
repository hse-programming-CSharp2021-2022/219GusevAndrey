using System;
namespace HW2
{
    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
        
    }

    class Circle : Shape
    {
        private double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }
        public override double Area()
        {
            return 2 * Math.PI * R;
        }

        public override string ToString()
        {
            return $"Circle - Area = {Area()}";
        }
    }

    class Cylinder : Shape
    {
        private double R { get; set; }
        private double H { get; set; }
        public Cylinder(double r, double h)
        {
            R = r;
            H = h;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(R,2) * 2 + 2 * Math.PI * R * H;
        }

        public override string ToString()
        {
            return $"Cylinder - Area = {Area()}";
        }
    }

    class Sphere : Shape
    {
        private double R { get; set; }
        public Sphere(double r)
        {
            R = r;
        }

        public override double Area()
        {
            return 4 * R * Math.PI * R;
        }
        public override string ToString()
        {
            return $"Sphere - Area = {Area()}";
        }
    }

    class Program
    {
        public static int comp(Shape a, Shape b)
        {
            if (a is Circle && b is Circle)
                return 1;
            if (a is Circle && b is Cylinder)
                return 1;
            if (a is Circle && b is Sphere)
                return 1;
            if (a is Sphere && b is Circle)
                return -1;
            if (a is Sphere && b is Cylinder)
                return 1;
            if (a is Sphere && b is Sphere)
                return 0;
            if (a is Cylinder && b is Circle)
                return -1;
            if (a is Cylinder && b is Cylinder)
                return 0;
            if (a is Cylinder && b is Sphere)
                return -1;
            return 0;
        }
        
        static void Main(string[] args)
        {
            var rand = new Random();
            var n1 = rand.Next(3, 6);
            var n2 = rand.Next(3, 6);
            var n3 = rand.Next(3, 6);
            var arr = new Shape[n1 + n2 + n3];
            int num = 0;
            for (var i = 0; i < n1; i++)
            {
                arr[num] = new Circle(rand.Next(0,50));
                num++;
            }

            for (var i = 0; i < n2; i++)
            {
                arr[num] = new Cylinder(rand.Next(0,50), rand.Next(0,50));
                num++;
            }

            for (var i = 0; i < n3; i++)
            {
                arr[num] = new Sphere(rand.Next(0,50));
                num++;
            }
            Array.Sort(arr, comp);
            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }
        }
    }
}