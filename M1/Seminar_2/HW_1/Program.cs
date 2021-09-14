using System;
namespace HW_1
{
    class Program
    {
        public static double F(double x)
        {
            double k1, k2, k3, k4 = x;
            k3 = k4 * k4;
            k2 = k4 * k3;
            k1 = k3 * k3;
            return 12 * k1 + 9 * k2 - 3 * k3 + 2 * k4 - 4;
        }
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число: ");
                double x;
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    double ans = F(x);
                    Console.WriteLine(ans);
                }
                Console.Write("Для выхода нажмите Enter, чтобы повторить, нажмите любую другую клавишу ");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}