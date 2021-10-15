using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";
            var n = int.Parse(Console.ReadLine());
            // Создаем файл с данными
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.WriteAllText(path, "");
            var myRandom = new Random();
            for (var i = 0; i < n; i++)
            {
                string ans = "";
                for (var j = 0; j < 5; j++)
                {
                    ans += myRandom.Next(10, 100).ToString() + ' ';
                }

                ans += '\n';
                File.AppendAllText(path,ans,Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues, n);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }

                var chet = new int[0];
                var nChet = new int[0];
                for (int i = 0; i < n * 5; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Array.Resize(ref chet,chet.Length + 1);
                        chet[chet.Length - 1] = i;
                    }
                    else
                    {
                        Array.Resize(ref nChet,nChet.Length + 1);
                        nChet[nChet.Length - 1] = i;
                        arr[i] = 0;
                    }
                }
                Console.WriteLine();
                foreach (var el in chet)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
                foreach (var el in nChet)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
                foreach (var el in arr)
                {
                    Console.Write($"{el} ");
                }

            }
        } // end of Main()


        public static int[] StringArrayToIntArray(string[] str, int n)
        {
            int[] arr = new int[n * 5];
            if (str.Length != 0)
            {
                int i = 0;
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        arr[i] = tmp;
                        i++;
                    }
                } // end of foreach (string s in str)      
            }

            return arr;
        } // end of StringToIntArray()
    } // end of Program
}