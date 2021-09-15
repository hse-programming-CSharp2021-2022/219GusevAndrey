namespace CW2
{
    internal class Program
    {
        public static void C_for()
        {
            for (int i = 1; i < 11; i++)
            {
                System.Console.WriteLine("" + (i * i));
            }
        }

        public static void C_while()
        {
            int k = 1;
            while (k < 11)
            {
                System.Console.WriteLine("" + (k * k));
                k++;
            }   
        }

        public static void C_do_while()
        {
            int k = 1;
            do
            {
                System.Console.WriteLine("" + (k * k));
                k++;
            } while (k != 11);
        }
        
        
        public static void Main(string[] args)
        {
            C_for();
            C_while();
            C_do_while();
        }
    }
}