using System;
namespace HW_2
{
    class Program
    {
        public static double Function(double x, double y)
        {
            if (x < y && x > 0)
            {
                return 1.0 * x + Math.Sin(y);
            } else if (x > y && x < 0)
            {
                return 1.0 * y - Math.Cos(x);
            }
            else
            {
                return 0.5 * x * y;
            }
            
                
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
                    string result = "G(x,y) = " + Function(x, y);
                    Console.WriteLine(result);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}