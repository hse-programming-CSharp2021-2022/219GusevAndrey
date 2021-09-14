using System;
namespace HW_4
{
    class Program
    {
        public static string Function(string s)
        {
            char[] g = s.ToCharArray();
            Array.Reverse(g);
            string ans = new string (g);
            return ans;
        }
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число: ");
                double x;
                string s;
                s = Console.ReadLine();
                if (!double.TryParse(s, out x) || x > 9999 || x < 1000 || x != (int)x)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    string ans = Function(s);
                    Console.WriteLine(ans);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}