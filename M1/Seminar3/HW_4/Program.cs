using System;
namespace HW_3
{
    class Program
    {
        public static double Function(double x, double y, double z)
        {
            int a = (int) x, b = (int) y, c = (int) z;
            int a1 = a % 100;
            int b1 = b % 100;
            int c1 = c % 100;
            if (a1 < b1)
            {
                if (a1 < c1)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b1 < c1)
                {
                    return b;
                }
                else
                {
                    return c;
                }
                
            }
        }

        public static bool is_good(double a)
        {
            return (a == (int)a && a < 1000 && a > 99);
        }
        
        public static void Main(string[] args)
        {
            do
            {
                double x, y, z;
                bool flag = true;
                Console.Write("Введите x: ");
                flag &= double.TryParse(Console.ReadLine(), out x);
                Console.Write("Введите y: ");
                flag &= double.TryParse(Console.ReadLine(), out y);
                Console.Write("Введите z: ");
                flag &= double.TryParse(Console.ReadLine(), out z);
                if (!flag || !is_good(x) || !is_good(y) || !is_good(z))
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    string result = "Наименьший номер комнаты - " + Function(x,y,z);
                    Console.WriteLine(result);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}