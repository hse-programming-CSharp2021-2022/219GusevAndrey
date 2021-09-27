using System;
namespace CW1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var num = Int32.Parse(Console.ReadLine());
            for (int i = 9; i >= 0; i--)
            {
                var a = num;
                while (a > 0)
                {
                    if (a % 10 == i)
                        Console.Write(i);
                    a /= 10;
                }
            }
        }
    }
}