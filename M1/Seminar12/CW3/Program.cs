using System;
using System.Text.RegularExpressions;

namespace CW3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b\w{4}\b";
            //Console.WriteLine(Regex.Matches(input, pattern));
            foreach (var el in Regex.Matches(input, pattern))
            {
                Console.WriteLine(el);
            }
        }
    }
}