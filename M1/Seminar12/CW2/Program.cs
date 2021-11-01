using System;
using System.Linq;

namespace CW2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var n);
            var myRand = new Random();
            var arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = myRand.Next(1, 10000);
            }
            
            // Вывод массива.
            foreach (var el in arr)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
            
            //двузначные числа кратные 3
            foreach (var el in arr.Select(x =>
            {
                if (x / 100 == 0 && x / 10 > 0 && x % 3 == 0)
                {
                    return x.ToString();
                }

                return "";
            })) 
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
            
            foreach (var el in arr.Select(x =>
            {
                var a = x.ToString();
                for (int i = 0; i < a.Length / 2; i++)
                {
                    if (a[i] != a[a.Length - 1 - i])
                        return "";
                }

                return a;
            }))
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();

            var ans = 0;
            foreach (var el in arr.Select(x => (x / 1000 == 0 ? x : 0)))
            {
                ans += el;
            }
            Console.WriteLine(ans);

            var mn = 10000;
            foreach (var el in arr.Select(x =>
            {
                if (x / 100 > 0 && x / 1000 == 0)
                {
                    return x;
                }

                return 100000;
            }))
            {
                mn = Math.Min(mn, el);
            }

            Console.WriteLine(mn);

            //int ind = 0;
            //var arrAns = new int[n];
            foreach (var el in arr.Select(x =>
            {
                int mx = 0, a = x;
                while (a > 0)
                {
                    mx = Math.Max(mx, a % 10);
                    a /= 10;
                }

                return mx;
            }))
            {
                Console.Write($"{el} ");
            }
            
        }

        
    }
}