using System;

namespace CW3
{
    internal class Program
    {
        public static bool gen(ref (int,bool)[] arr, int k)
        {
            Random myRand = new Random();
            int[] used = new int[101];
            int flag = 0;
            for (int i = 0; i < k; i++)
            {
                int a = 0;
                do
                {
                    a = myRand.Next(1, 101);
                } while (used[a] != 0 && used[a] != (flag == 0 ? 1 : 0));

                if (used[a] == 1 && flag == 0)
                {
                    Console.WriteLine(a);
                    flag = 1;
                }
                arr[i].Item1 = a;
                used[a] = 1;
            }

            if (flag == 1)
                return true;
            return false;
        }
        public static void Main(string[] args)
        {
            var k = 101;
            var arr = new (int, bool)[k];
            //int[] arr = new int[k];
            while (!gen(ref arr, 99));
            for (int i = 0; i < 99; i++)
            {
                if (arr[arr[i].Item1].Item2)
                    Console.WriteLine(arr[i].Item1);
                arr[arr[i].Item1].Item2 = true;
            }
        }
    }
}