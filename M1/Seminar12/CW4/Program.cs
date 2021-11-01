using System;
using System.Text.RegularExpressions;
namespace CW4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b\w*a\b";
            foreach (var el in Regex.Matches(input, pattern))
            {
                Console.WriteLine(el);
            }
        }
    }
}