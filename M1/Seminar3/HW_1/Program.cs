using System;
namespace HW_1
{
    class Program
    {
        public static bool Function(double x, double y)
        {
            double gip = Math.Sqrt(x * x + y * y);
            return (x * x + y * y <= 4 && ((x > 0 && Math.Asin(1.0 * y / gip) - (1.0 * Math.Sqrt(2) / 2) >= 0.0001) || x <= 0));
        }
        public static void Main(string[] args)
        {
            do
            {
                double x, y;
                bool flag = true;
                Console.Write("Введите x: ");
                flag &= double.TryParse(Console.ReadLine(), out x);
                Console.Write("Введите y: ");
                flag &= double.TryParse(Console.ReadLine(), out y);
                if (!flag)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    string result = "Точка попадает в область фигуры G - " + Function(x, y);
                    Console.WriteLine(result);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}