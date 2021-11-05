using System;

namespace HW1
{
    internal class Program
    {
        public class ConsolePlate
        {
            private char _plateChar;
            private ConsoleColor _plateColor = ConsoleColor.White;
            private ConsoleColor _backgroundColor;

            public char PlateChar
            {
                set
                {
                    if (value < 'A' || value > 'Z') _plateChar = 'A';
                    else _plateChar = value;
                }
                get { return _plateChar; }
            }

            public ConsoleColor PlateColor
            {
                set
                {
                    _plateColor = value;
                }
                get
                {
                    return _plateColor;
                }
            }

            public ConsoleColor BackgroundColor
            {
                set
                {
                    if (_plateColor == value)
                        _backgroundColor = (ConsoleColor) (((int) value + 1) % 16);
                    else
                        _backgroundColor = value;
                }
                get
                {
                    return _backgroundColor;
                }
            }

            public ConsolePlate()
            { 
                PlateChar = 'A';
            }

            public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor backgroundColor)
            {
                PlateChar = plateChar;
                PlateColor = plateColor;
                BackgroundColor = backgroundColor;
            }
            
            public override string ToString()
            {
                Console.ForegroundColor = PlateColor;
                Console.BackgroundColor = BackgroundColor;
                return PlateChar.ToString();
            }
        }

        public static void Main(string[] args)
        {
            var arr = new ConsolePlate[1000];
            var rand = new Random();
            for (var i = 0; i < 1000; i++)
            {
                arr[i] = new ConsolePlate((char)rand.Next(0, 150), (ConsoleColor)rand.Next(0, 16),(ConsoleColor)rand.Next(0, 16));
                Console.Write(arr[i]);
            }
            Console.BackgroundColor = default;
            Console.ForegroundColor = default;
            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());

            ConsolePlate o = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            ConsolePlate x = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write(o);
                    else
                        Console.Write(x);
                }
                Console.WriteLine();
            }
            

        }
    }
}