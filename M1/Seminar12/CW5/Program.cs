using System;
using System.Text.RegularExpressions;
namespace CW5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\d*";
            string ans = "";
            foreach (var el in Regex.Matches(input, pattern))
            {
                if (ans.Length < el.ToString().Length)
                    ans = el.ToString();
            }
            Console.WriteLine(ans);
        }
    }
}