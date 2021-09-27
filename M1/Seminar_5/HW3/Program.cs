using System;

namespace HW3
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">NOD</param>
        /// <param name="b">NOK</param>
        public static void NokNod(ref int a, ref int b)
        {
            int num1 = a, num2 = b;
            for (int i = 2; i < 1e+8; i++)
                if (a % i == 0 && b % i == 0)
                {
                    a = i;
                    break;
                }
            for (int i = Math.Max(num1,num2); i < num1 * num2; i++)
                if (i % num1 == 0 && i % num2 == 0)
                {
                    b = i;
                    break;
                }
        }
        public static void Main(string[] args)
        {
            var a = Int32.Parse(Console.ReadLine());
            var b = Int32.Parse(Console.ReadLine());
            NokNod(ref a, ref b);
            Console.WriteLine("" + a + " " + b);
        }
    }
}