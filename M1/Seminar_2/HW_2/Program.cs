using System;
namespace HW_2
{
    class Program
    {
        public static int Function(int x)
        {
            int a = x % 10;
            int b = x / 10 % 10;
            int c = x / 100;
            int ans = Math.Max(a, Math.Max(b, c)) * 100 +
                      (a + b + c - Math.Max(a, Math.Max(b, c)) - Math.Min(a, Math.Min(b, c))) * 10 +
                      Math.Min(a, Math.Min(b, c));
            return ans;
        }
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число: ");
                double x;
                if (!double.TryParse(Console.ReadLine(), out x) || x > 999 || x < 100 || x != (int)x)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    int ans = Function((int)x);
                    Console.WriteLine(ans);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}