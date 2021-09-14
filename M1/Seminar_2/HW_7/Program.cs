using System;
namespace HW_7
{
    class Program
    {
        public static string Function1(double s)
        {
            int x = (int) s;
            return "Целая часть числа - " + x + ". Дробная часть числа - " + (s - x) + "." + '\n';
        }
        public static string Function2(double s)
        {
            if (s < 0)
                return "Число отрицательная - корень выделить нелья. Квадрат числа - " + (s * s) + ".";
            else
                return "Корень числа - " + (Math.Sqrt(s)) + ". Квадрат числа - " + (s * s) + ".";
        }
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число: ");
                double x;
                string s = Console.ReadLine();
                if (!double.TryParse(s, out x) || x == (int)x)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    string ans = Function1(x) + Function2(x);
                    Console.WriteLine(ans);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}