using System;
namespace HW_6
{
    class Program
    {
        public static decimal Function(decimal x, int y)
        {
            return x * (decimal)(y * 1.0 / 100);
        }
        public static void Main(string[] args)
        {
            do
            {
                decimal x;
                double y;
                bool flag = true;
                Console.Write("Введите бюджет: ");
                flag &= decimal.TryParse(Console.ReadLine(), out x);
                Console.Write("Введите процент бюджета, выделенный на комп. игры: ");
                flag &= double.TryParse(Console.ReadLine(), out y);
                if (!flag || (int)y != y || y < 0 || y > 100)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    decimal ans = Function(x, (int)y);
                    Console.WriteLine(ans.ToString("C"));
                }
                Console.Write("Для выхода нажмите esc, чтобы повторить, нажмите любую другую клавишу ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}