using System;
using System.Text.RegularExpressions;
namespace HW3
{
    internal class Program
    {
        /// <summary>
        /// Выводит количество слов длины 5+.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b\w{5,}\b";
            var ans = Regex.Matches(input, pattern).Count;
            Console.WriteLine(ans);
        }
    }
}