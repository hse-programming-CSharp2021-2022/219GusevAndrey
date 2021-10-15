using System;
namespace CW1
{
    internal class Program
    {
        public static int comp1(int a, int b)
        {
            if (a % 2 == b % 2)
            {
                if (a > b)
                    return 1;
                else
                    return -1;
            }
                
            if (a % 2 == 0 && b % 2 > 0)
                return -1;
            if (a % 2 > 0 && b % 2 == 0)
                return 1;
            return 1;
        }
        public static int comp2(int a, int b)
        {
            var ch1 = 0;
            var ch2 = 0;
            while (a > 0)
            {
                a /= 10;
                ch1++;
            }

            while (b > 0)
            {
                ch2++;
                b /= 10;
            }

            if (ch1 > ch2)
                return -1;
            return 1;
        }
        
        public static int comp3(int a, int b)
        {
            var ch1 = 0;
            var ch2 = 0;
            while (a > 0)
            {
                ch1 += a % 10;
                a /= 10;
            }

            while (b > 0)
            {
                ch2 += b % 10;
                b /= 10;
            }

            if (ch1 > ch2)
                return -1;
            return 1;
        }

        
        public static void Main(string[] args)
        {
            var n = 50;
            var v = new int[n];
            var myRandom = new Random();
            for (int i = 0; i < n; i++)
            {
                v[i] = myRandom.Next(0, 100);
            }
            Array.Sort(v, comp1);
            foreach (var x in v)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Array.Sort(v,comp2);
            foreach (var x in v)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Array.Sort(v,comp3);
            foreach (var x in v)
            {
                Console.Write(x + " ");
            }
        }
    }
}