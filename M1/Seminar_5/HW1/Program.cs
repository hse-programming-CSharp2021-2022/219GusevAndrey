using System;

namespace HW1
{
    internal class Program
    {
        public static bool Shift(ref char ch)
        {
            var a = (int) ch;
            if (a > 122 || a < 97)
                return false;
            ch = (a + 4 > 122 ? ((char) (97 + (a + 4) % 123)) : (char) (4 + a));
            return true;
        }
        public static void Main(string[] args)
        {
            var a = char.Parse(Console.ReadLine());
            if (Shift(ref a))
                Console.WriteLine(a);
        }
    }
}