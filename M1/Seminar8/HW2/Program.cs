using System;
namespace HW2
{
    public static class Program
    {
        public static void Function(double[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += arr[j, i];
                }
                Console.Write($"{sum:F2} ");
            }
        }
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new double[n][];
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = new double[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.NextDouble();
                }
            }
            Array.ForEach(arr, el =>
            {
                Array.ForEach(el, elem => Console.Write($"{elem:F2} "));
                Console.WriteLine();
            });
            var newArr = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < Math.Min(n, arr[i].Length); j++)
                {
                    newArr[i, j] = arr[i][j];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{newArr[i,j]:F2} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Function(newArr, n);
        }
    }
}