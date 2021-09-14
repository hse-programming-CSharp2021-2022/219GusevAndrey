using System;
namespace HW_5
{
    class Program
    {
        public static string Function(double a, double b, double c)
        {
            bool g = ((a + b) > c) && ((a + c) > b) && ((b + c) > a);
            return ("Треугольник с введеными длинами сторон существует - " + g);
        }
        public static void Main(string[] args)
        {
            do
            {
                double a, b, c;
                bool flag = true;
                Console.Write("Введите сторону треугольника (a): ");
                flag &= double.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите сторону треугольника (b): ");
                flag &= double.TryParse(Console.ReadLine(), out b);
                Console.Write("Введите сторону треугольника (c): ");
                flag &= double.TryParse(Console.ReadLine(), out c);
                if (!flag)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    string result = Function(a, b, c);
                    Console.WriteLine(result);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}