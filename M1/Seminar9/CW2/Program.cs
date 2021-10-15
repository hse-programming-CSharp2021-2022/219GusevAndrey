using System;
using System.Linq;

namespace CW2
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            string num = Console.ReadLine();
            string myNaull = new string('0', num.Length % 4);
            var arr = new string[16];
            //Console.WriteLine(myNaull);
            for (int i = 0; i < 16; i++)
            {
                string myStr = "";
                for (int j = 0; j < 4; j++)
                {
                    int a = (i >> j) % 2;
                    myStr += a;
                }

                string f = "";
                int ch = 0;
                for (int j = 3; j >= 0; j--)
                {
                    f += myStr[j];
                }
                myStr = f;
                arr[i] = myStr;
                
               // Console.WriteLine(myStr);
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 'A') 
                    Console.Write(arr[10]);
                else
                if (num[i] == 'B') 
                    Console.Write(arr[11]);
                else
                if (num[i] == 'C') 
                    Console.Write(arr[12]);
                else
                if (num[i] == 'D') 
                    Console.Write(arr[13]);
                else
                if (num[i] == 'E') 
                    Console.Write(arr[14]);
                else
                if (num[i] == 'F') 
                    Console.Write(arr[15]);
                else
                    Console.Write(arr[int.Parse((num[i]).ToString())]);
            }
            
        }

    }
}