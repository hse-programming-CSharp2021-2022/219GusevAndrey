using System;
namespace Seminar10
{
    internal class Program
    {

        static char[] Function(int n)
        {
            var arrayOfChar = new char[n];
            var myRandom = new Random();
            for (int i = 0; i < (int)(n * 0.30); i++)
            {
                arrayOfChar[i] = (char)myRandom.Next('a','z' + 1);
            }

            for (int i = (int) (n * 0.30); i < n; i++)
            {
                arrayOfChar[i] = (char)myRandom.Next('0','9' + 1);
            }

            return arrayOfChar;
        }

        static public string MyPrint(char[] myArr)
        {
            string[] strArr = {"ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
            string ans = "";
            for (var i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] >= '0' && myArr[i] <= '9')
                {
                    ans += strArr[(int.Parse(myArr[i].ToString()))] + " ";
                }
                else
                {
                    ans += myArr[i].ToString() + " ";
                }
            }

            return ans;
        }
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var n);
            var myRandom = new Random();
            var arrayOfChar = Function(n);

            foreach (var el in arrayOfChar)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();

            string s = MyPrint(arrayOfChar);
            
            Console.Write(s);
        }
    }
}