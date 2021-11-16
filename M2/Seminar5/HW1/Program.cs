using System;

namespace HW1
{

    public class Cinderella
    {
        protected Random rand = new Random();
        public string where = "Base";
        public override string ToString()
        {
            return where;
        }
    }
    abstract class Something : Cinderella
    {
    }

    class Lentil : Something
    {
        private double Weight => rand.Next(0,3) + rand.NextDouble();
        new string where = "Lentil";
        public override string ToString()
        {
            return where + $" Weight = {Weight}";
        }
    }

    class Ashes : Something
    {
        private double Volume => rand.Next(0,2) + rand.NextDouble();
        new string where = "Ashes";
        public override string ToString()
        {
            return where + $" Volume = {Volume}";
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            var n = rand.Next(0, 100);
            Cinderella el;
            var arr = new Cinderella[n];
            for (int i = 0; i < n; i++)
            {
                if (rand.Next(0, 2) == 1)
                {
                    el = new Lentil();
                }
                else
                {
                    el = new Ashes();
                }

                arr[i] = el;
            }
            foreach (var ell in arr)
            {
                Console.WriteLine(ell);
            }
        }
    }
}