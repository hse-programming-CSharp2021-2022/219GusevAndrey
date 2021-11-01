using System;
using System.Collections.Generic;
using System.Linq;

namespace CW6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var myStringArray = input.Split();
            foreach (var el in myStringArray.Select(x =>
            {
                Stack<char> myStack = new Stack<char>();
                foreach (var el in x)
                {
                    if (el == '(' || el == '[' || el == '{') 
                        myStack.Push(el);
                    else
                    {
                        char myChar;
                        if (myStack.Count > 0)
                            myChar = myStack.Pop();
                        else
                            return "";
                        if ((int) (myChar + 1) != (int) el && (int) (myChar + 2) != (int) el)
                        {
                            return "";
                        }
                    }
                }

                return x;
            }))
            {
                Console.WriteLine(el);
            }
        }
    }
}