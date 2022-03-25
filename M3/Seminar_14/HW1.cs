using System;
using System.Linq;
namespace HW1
{
    class Program
    {
        public static void Print(int[] arr) => Array.ForEach(arr, Console.WriteLine);
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            Random random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] =  random.Next(-1000,1001);
            }
            Print(array);
            Console.WriteLine();

            var array1 = array.Select(x => x*x).ToArray();
            Print(array1);
            Console.WriteLine();
            
            var array2 = array.Where(x => x > 0 && x < 100).ToArray();
            Print(array2);
            Console.WriteLine();
            
            var array3 = array.Where(x => x % 2 == 0).OrderByDescending(x => x).ToArray();
            Print(array3);
            Console.WriteLine();
            
            var array4 = array.GroupBy(x => x.ToString().Length).ToArray();
            Print(array4);
        }
    }
}