using System;
namespace CW2
{
    internal class Program
    {
        public static void Function(double a, double b, double c, double x)
        {
            if (x < 1.2)
            {
                Console.WriteLine($"x = {x}, y(x) = " + (a * x * x + b * x + c));
            }

            if (x == 1.2)
            {
                Console.WriteLine($"x = {x}, y(x) = " + (a / x + Math.Sqrt(x * x + 1)));
            }

            if (x > 1.2)
            {
                Console.WriteLine($"x = {x}, y(x) = " + ((a + b * x)/(Math.Sqrt(x * x + 1))));
            }
            
        }
        public static void Main(string[] args)
        {
            var a = Double.Parse(Console.ReadLine());
            var b = Double.Parse(Console.ReadLine());
            var c = Double.Parse(Console.ReadLine());
            for (var x = 1.0; x < 2.05; x+=0.05)
            {
                Function(a,b,c,x);
            }
        }
    }
}