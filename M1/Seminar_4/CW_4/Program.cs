using System;
namespace CW_4
{
    internal class Program
    {
        public static double Function(double m, double n)
        {
            if (m == 0)
            {
                return n + 1;
            }

            if (m > 0 && n == 0)
            {
                return Function(m - 1, 1);
            }
            else
            {
                return Function(m - 1, Function(m, n - 1));
            }
            
        }
        public static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Function(m,n));
        }
    }
}