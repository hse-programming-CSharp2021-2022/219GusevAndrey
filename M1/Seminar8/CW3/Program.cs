using System;
namespace CW3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n, n];
            var ch = 0;
            for (var i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (var j = 0; j < n; j++)
                    {
                        arr[i, j] = ch;
                        ch++;
                    }
                }
                else
                {
                    for (var j = n - 1; j >= 0; j--)
                    {
                        arr[i, j] = ch;
                        ch++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}