using System;
using System.Text.RegularExpressions;

namespace HW2
{
    internal class Program
    {
        /// <summary>
        /// Выводит количество слов, начинающихся с гласной.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string type = @"\b[aeuiyo]\w*\b";
            var ans = Regex.Matches(input, type).Count;
            Console.WriteLine(ans);
        }
    }
    
}