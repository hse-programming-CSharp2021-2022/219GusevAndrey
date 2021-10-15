using System;
namespace CW2
{
    internal class Program
    {
        public static int comp1(int a, int b)
        {
            if (a > b)
                return 1;
            return -1;
        }
        public static int comp2(int[] a, int[] b)
        {
            if (a.Length > b.Length)
                return -1;
            return 1;
        }
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n][];
            var myRand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[myRand.Next(5, 16)];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = myRand.Next(-10, 11);
                }
            }

            Array.ForEach(arr, el =>
                {
                    Array.ForEach(el, elem => Console.Write($"{elem} "));
                    Console.WriteLine();
                }
            );
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Array.Sort(arr[i], comp1);
            }
            Array.Sort(arr,comp2);
            Array.ForEach(arr, el =>
                {
                    Array.ForEach(el, elem => Console.Write($"{elem} "));
                    Console.WriteLine();
                }
            );
        }
    }
}