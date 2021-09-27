using System;
namespace CW_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double sum1 = 0, sum2 = -1;
            int k = 1;
            while (sum1 - sum2 > 0)
            {
                sum2 = sum1;
                sum1 += 1.0 / (k * (k + 1) * (k + 2));
                k++;
            }
            Console.WriteLine(sum1);
            float sum11 = 0, sum22 = -1;
            int k1 = 1;
            while (sum11 - sum22 > 0)
            {
                sum22 = sum11;
                sum11 += (float)1.0 / (k1 * (k1 + 1) * (k1 + 2));
                k1++;
            }
            Console.WriteLine(sum11);
        }
    }
}