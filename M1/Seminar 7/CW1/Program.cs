using System;
namespace CW1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            char[] arr = new char[k];
            Random myRand = new Random();
            for (int i = 0; i < k; i++)
            {
                arr[i] = (char)myRand.Next('A', 'Z' + 1);
                Console.Write("" + arr[i] + " ");
            }
            Console.WriteLine('\n');
            char[] b = new char[k];
            Array.Copy(arr, b, k);
            Array.Sort(b);
            for (int i = 0; i < k; i++)
            {
                Console.Write("" + b[i] + " ");
            }
            Console.WriteLine('\n');
            Array.Reverse(b);
            for (int i = 0; i < k; i++)
            {
                Console.Write("" + b[i] + " ");
            }
        }
    }
}