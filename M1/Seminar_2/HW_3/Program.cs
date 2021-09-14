using System;
namespace HW_3
{
    class Program
    {
        public static void Function(double a, double b, double c, ref double ans1, ref double ans2, ref string ans)
        {
            double D = b * b - 4 * a * c;
            ans = (a == 0
                ? "Не квадратное уравнение, x = " + (1.0 * -c / b)
                : (D < 0 ? "Уравнение содержит комплексные корни " : ""));
            ans1 = (ans.Length == 0 ? (1.0 * (-b - Math.Sqrt(D)) / (2.0 * a)) : 0);
            ans2 = (ans.Length == 0 ? (1.0 * (-b + Math.Sqrt(D)) / (2.0 * a)) : 0);
        }
        public static void Main(string[] args)
        {
            do
            {
                double a, b, c;
                bool flag = true;
                Console.Write("Введите коэффициент уравнения (a): ");
                flag &= double.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите коэффициент уравнения (b): ");
                flag &= double.TryParse(Console.ReadLine(), out b);
                Console.Write("Введите коэффициент уравнения (c): ");
                flag &= double.TryParse(Console.ReadLine(), out c);
                if (!flag)
                {
                    Console.WriteLine("incorrect input");
                }
                else
                {
                    double ans1 = 0, ans2 = 0;
                    string ans = "";
                    Function(a,b,c, ref ans1, ref ans2,ref ans);
                    string result;
                    result = (ans.Length == 0 ? "x1 = " + ans1 + " x2 = " + ans2 : "" + ans);
                    Console.WriteLine(result);
                }
                Console.Write("Для выхода нажмите esc; чтобы повторить, нажмите любую другую клавишу. ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}