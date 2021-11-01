using System;

namespace CW1
{
    class Polygon
    {
        public int N { get; set; }
        public int R { get; set; }
        public double A { get; set; }

        public Polygon(int n, int r)
        {
            N = n;
            R = r;
            A = Math.Tan((3.14 / n)) * 2 * R;
        }

        public double P
        {
            get { return N * A; }
        }

        public static double S(Polygon b)
        {
            return b.P / 2 * b.R;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = -1;
            var b = -1;
            double mnS = 100000;
            double mxS = -1;
            do
            {
                if (a > 0 || b > 0)
                {
                    var myPolygon = new Polygon(a, b);
                    Console.WriteLine("Perimetr:");
                    Console.WriteLine(myPolygon.P);
                    Console.WriteLine("Square:");
                    Console.WriteLine(Polygon.S(myPolygon));
                    mnS = Math.Min(mnS, Polygon.S(myPolygon));
                    mxS = Math.Max(mxS, Polygon.S(myPolygon));
                }

                Console.Write("Number of sides:");
                a = int.Parse(Console.ReadLine());
                Console.Write("Radius of the inscribed circle:");
                b = int.Parse(Console.ReadLine());
            } while (a != 0 && b != 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Min square: {mnS}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Max square: {mxS}");
        }
    }
}