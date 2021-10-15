using System;
using System.Linq;
using System.Text;

namespace HW1
{
    internal class Program
    {
        /// <summary>
        /// Удаляет лишние пробелы.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var strB = new StringBuilder();
            foreach (var el in input.Select(el =>
            {
                if (strB.Length > 0 && strB[strB.Length - 1] == ' ' && el == ' ')
                    return "";
                return el.ToString();
            }))
            {
                strB.Append(el);
            }
            Console.WriteLine(strB.ToString().Trim());
        }
    }
}