using System;
namespace HW2
{
    internal class Program
    {
        public static int Function(int n, ref int[] arr)
        {
            var result = 0;
            for (int i = 0; i < n - 1 - result; i++)
            {
                if ((arr[i] + arr[i + 1]) % 3 == 0)
                {
                    result++;
                    arr[i] = arr[i] * arr[i + 1];
                    for (int j = i + 1; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                }

                /*for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();*/
            }

            return result;
        }
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var myArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            n -= Function(n,ref myArr);
            for (int i = 0; i < n; i++)
                Console.WriteLine(myArr[i]);
        }
    }
}