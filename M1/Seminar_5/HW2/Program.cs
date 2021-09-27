using System;
using Microsoft.Win32;

namespace HW2
{
    internal class Program
    {
        public static int Fact(int a)
        {
            if (a <= 1)
                return 1;
            return a * Fact(a - 1);
        }
        public static double M1(double x)
        {
            var ch = 4;
            var now1 = 1.0;
            var ans = x * x;
            double new2 = x * x + 1;
            var i = 0;
            while (ans != Double.PositiveInfinity)
            {
                new2 = ans;
                now1 = 1.0 * (Math.Pow(2,ch - 1)) * Math.Pow(x, ch) / Fact(ch);
                ans -= now1;
                ch += 2;
                now1 = 1.0 * (Math.Pow(2,ch - 1)) * Math.Pow(x, ch) / Fact(ch);
                ans += now1;
                i++;
            }

            return new2;
        }
        
        public static double M2(double x)
        {
            var ans1 = 1.0;
            var ans2 = 0.0;
            var ch = 1;
            while (ans1 - ans2 > 0)
            {
                ans2 = ans1;
                ans1 += 1.0 * Math.Pow(x, ch) / Fact(ch);
                ch++;
            }
            return ans1;
        }
        public static void Main(string[] args)
        {
            var x = Double.Parse(Console.ReadLine());
            Console.WriteLine(M1(x));
            Console.WriteLine(M2(x));
        }
    }
}