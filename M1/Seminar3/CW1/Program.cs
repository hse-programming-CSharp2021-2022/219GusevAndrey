namespace CW1
{
    static class Program
    {
        public static bool Function1(bool p, bool q) {
            return (!(p & q) & !(p | !q));
        }
        public static void Function2(bool p,bool q, ref bool ans) {
            ans = !(p & q) & !(p | !q);
        }
        public static void Main(string[] args)
        {
            bool ans = false;
            Function2(false, false, ref ans);
            System.Console.WriteLine("False False = " + Function1(false,false)+ "   " + ans);
            Function2(false, true, ref ans);
            System.Console.WriteLine("False True = " + Function1(false, true) + "   " + ans);
            Function2(true, false, ref ans);
            System.Console.WriteLine("True False = " + Function1(true,false)+ "   " + ans);
            Function2(true, true, ref ans);
            System.Console.WriteLine("True True = " + Function1(true, true) + "   " + ans);

        }
    }
}