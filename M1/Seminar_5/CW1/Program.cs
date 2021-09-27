using System;
namespace CW1
{
    internal class Program
    {
        public static void MySum(int x, ref int sum1, ref int sum2)
        {
            int i = 0;
            while (x > 0)
            {
                if (i % 2 == 0)
                {
                    sum1 += x % 10;
                    x = x / 10;
                }
                else
                {
                    sum2 += x % 10;
                    x = x / 10;
                }
                i++;
            }
        }
        
        
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            MySum(x,ref sum1, ref sum2);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}