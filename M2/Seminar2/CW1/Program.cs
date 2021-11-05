using System;
namespace CW1
{
    class MyComplex
    {
        public double re { get; }
        public double im { get; }

        public MyComplex(double xre, double xim)
        {
            re = xre;
            im = xim;
        }

        // Неправильная реализация:
        //public static MyComplex operator ++(MyComplex mc)
        //{ mc.re++; mc.im++; return mc; }
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }
        
        public static MyComplex operator ++(MyComplex mc)
        {
            return new MyComplex(mc.re + 1, mc.im + 1);
        }

        public double Mod()
        {
            return Math.Abs(re * re + im * im);
        }

        public static bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }

        public static bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re + b.re, a.im + b.im);
        } 
        
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re - b.re, a.im - b.im);
        } 
        
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re * b.re - a.im - b.im, a.re * b.re + a.im - b.im);
        } 
        
        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex((a.re * b.re + a.im - b.im) / (b.re * b.re + b.im * b.im), (b.re * b.re - a.im - a.im) / (b.re * b.re + b.im * b.im));
        }

        public override string ToString()
        {
            return re + " " + im;
        }
        
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new MyComplex(10f, 21f);
            var b = new MyComplex(8f, 12f);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}