using System;
namespace CW_5
{
    internal class Program
    {
        public static double Make_ans(double sum, double proc, int n)
        {
            if (n == 0)
            {
                return proc * sum + sum;
            }
            else
            {
                return Make_ans(sum, proc, n - 1) * proc + sum;
            }
        }
        
        public static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            double proc = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Make_ans(sum, 1.0 * proc / 100, n));
        }
    }
}