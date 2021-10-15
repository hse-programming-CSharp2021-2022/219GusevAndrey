using System;
namespace HW1
{
    internal class Program
    {
        public static void Function(int n, ref double[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                
            }
        }
    
       /// <summary>
        /// Ex3
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var myArr = new double[n];
            Function(n,ref myArr);
        }
    }
}