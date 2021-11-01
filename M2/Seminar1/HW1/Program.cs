using System;
namespace HW1
{
    class Point
    {
        public double X
        {
            set;
            get;
        }
        public double Y
        {
            set;
            get;
        }

        public Point()
        {
            X = 3;
            Y = 3;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Fi
        {
            get
            {
                if (X > 0 && Y >= 0) return Math.Atan(Y / X);
                if (X > 0 && Y < 0) return Math.Atan(Y / X) + 2 * Math.PI;
                if (X < 0) return Math.Atan(Y / X) + Math.PI;
                if (X == 0 && Y > 0) return Math.PI / 2;
                if (X == 0 && Y < 0) return 3 * Math.PI / 2;
                if (X == 0 && Y == 0) return 0;
                return -1;
            }
        }

        public double r
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        
        
    }
    internal class Program
    {
        public static int Comp(Point a, Point b)
        {
            if (a.r > b.r)
                return 1;
            return -1;
        }
        
        public static void Main(string[] args)
        {
            Point a = new Point(4, 5);
            Point b = new Point(1, -4);
            int.TryParse(Console.ReadLine(), out var x);
            int.TryParse(Console.ReadLine(), out var y);
            Point c = new Point(x, y);
            var myArr = new Point[3];
            myArr[0] = a;
            myArr[1] = b;
            myArr[2] = c;
            Array.Sort(myArr, Comp);
            foreach (var el in myArr)
            {
                Console.WriteLine($"X: {el.X}, Y: {el.Y}, Fi: {el.Fi}, r: {el.r}");
            }
        }
    }
}