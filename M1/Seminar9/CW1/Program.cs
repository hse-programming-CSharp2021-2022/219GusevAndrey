using System;
using System.Xml.Xsl;

namespace CW1
{
    internal class Program
    {
        public static string Function(string s)
        {
            char[] myChar = {'a', 'e', 'i', 'o', 'u','y'};
            string ans = "";
            bool flag = false;
            bool check = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ';')
                {
                    if (s[i] == ' ')
                    {
                        flag = false;
                        check = false;
                    }
                    else
                    {
                        if (flag == false)
                        {
                            if ((int) (s[i]) >= 97)
                                ans += (char) ((int) (s[i]) - 32);
                            else
                                ans += s[i];
                            flag = true;
                        }
                        else
                        {
                            if (check == false)
                            {
                                foreach (var el in myChar)
                                {
                                    if (el == s[i])
                                    {
                                        check = true;
                                    }
                                }
                                
                                if ((int) (s[i]) < 97)
                                    ans += s[i];
                                else
                                    ans += (char) ((int) (s[i]) + 32);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(ans);
                    ans = "";
                    flag = false;
                    check = false;
                }
            }

            return s;
        }
        public static void Main(string[] args)
        { 
            Console.WriteLine((int)'a');
            Console.WriteLine((int)'A');
            var s = Console.ReadLine();
            string newS = Function(s);
            //Console.WriteLine((int)'a');
        }
    }
}