using System;
static class Program
{
    public static void Main()
    {
        float x, y;
        bool flag = true;
        flag &= float.TryParse(Console.ReadLine(), out x);
        flag &= float.TryParse(Console.ReadLine(), out y);
        if (!flag || x < 0 || y < 0)
        {
            Console.WriteLine("Mistake");
            return;
        }
        else
        {
            Console.WriteLine(Math.Sqrt(x * x + y * y));
        }
    }
}