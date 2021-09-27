using System;

namespace CW3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var M = Int32.Parse(Console.ReadLine());
            var N = Int32.Parse(Console.ReadLine());
            int ans = (1 << N) + (1 << M);
            Console.WriteLine(ans);
        }
    }
}