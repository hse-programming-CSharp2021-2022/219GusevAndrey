using System;
namespace HW_3
{
    class Program
    {
        public static double Function(double x)
        {
            if (x <= 0.5)
            {
                return (Math.Sin(1.0 * Math.PI / 2));
            }
            else
            {
                return (1.0 * Math.Sin(1.0 * Math.PI * (x - 1) / 2));
            }
                
        }
        public static void Main(string[] args)
        {
            do
            {
                double x;
                bool flag = true;
                Console.Write("Введите x: ");
                flag &= double.TryParse(Console.ReadLine(), out x);
                if (!flag)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    string result = "G(x) = " + Function(x);
                    Console.WriteLine(result);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}