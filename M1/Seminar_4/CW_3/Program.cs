using System;
namespace CW_3
{
    internal class Program
    {
        public static int make_ans(int x, int ch = 0)
        {
            if (ch == 0)
                return 1 + make_ans(x / 10, ch + 1);
            if (x > 0)
            {
                return 1 + make_ans(x / 10, ch + 1);
            }
            else
            {
                return 0;
            }
        }
        
        
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(make_ans(a));
        }
    }
}