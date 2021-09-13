using System;
    internal class Program
    {
        public static void Main(string[] args)
        {
            double U, R;
            bool flag = true;
            flag &= double.TryParse(Console.ReadLine(), out U);
            flag &= double.TryParse(Console.ReadLine(), out R);
            if (!flag)
            {
                Console.WriteLine("Mistake");
                return;
            }

            double I = U / R;
            double P = U * U / R;
            Console.WriteLine("Сила тока: " + I);
            Console.WriteLine("Мощность: " + P);
        }
    }
