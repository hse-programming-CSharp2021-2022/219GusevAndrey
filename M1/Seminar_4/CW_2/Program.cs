using   System;
namespace CW_2
{
    internal class Program
    {
        public static double F(double x)
        {
            return x * x;
        }
        
        public static double Make_ans(double D, int n)
        {
            double ans = 0;
            double i;
            for (i = 1; i <= n; i += D)
            {
                ans += 1.0 * (F(i) + F(i - 1)) / 2 * D;
            }

            if (i - D != n)
            {
                ans += 1.0 * (F(i - D) + F(n)) / 2 * D;
            }

            return ans;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());
            Console.WriteLine(Make_ans(D,n));
        }
    }
}