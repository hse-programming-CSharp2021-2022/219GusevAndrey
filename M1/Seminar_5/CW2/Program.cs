using System;
using System.Xml.Xsl;

namespace CW2
{
    internal class Program
    {
        public static void Function(int k, int n,int sum)
        {
            Console.Write(sum);
        }
        
        public static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i < k; i++)
            {
                Function(1,i, 0);
            }
        }
    }
}