using System;
using System.Collections.Generic;
using System.Linq;

namespace CW1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] names = {"sdasdd", "sadada", "asdasd", "Asdsds"};
            foreach (var el in names.Select(x =>
            {
                if (x.ToUpper().StartsWith("A"))
                    return x;
                return "";
            }))
            {
                Console.Write($"{el} ");
            }
            
        }
    }
}