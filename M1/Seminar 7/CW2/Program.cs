using System;
namespace CW2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int k = 99;
            int[] arr = new int[k];
            bool[] used = new bool[101];
            Random myRand = new Random();
            for (int i = 0; i < k; i++)
            {
                int a = 0;
                do
                {
                    a = myRand.Next(1, 101);
                } while (used[a] != false);

                arr[i] = a;
                used[a] = true;
            }

            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
            }

            for (int i = 0; i < k; i++)
                sum -= arr[i];
            
            Console.WriteLine(sum);
        }
    }
}