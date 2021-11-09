using System;
using System.Collections.Generic;

namespace HW1
{
    class VideoFile
    {
        private string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        
        private int _duration;
        public int Duration
        {
            set { _duration = value; }
            get { return _duration; }
        }
        
        private int _size;
        public int Size
        {
            set { _size = value;}
            get { return _size; }
        }

        private int _quality;
        public int Quality
        {
            set { _quality = value;}
            get { return _quality; }
        }

        public VideoFile()
        {
            var rand = new Random();
            var nameLength = rand.Next(2,10);
            for (int i = 0; i < nameLength; i++)
            {
                Name += (char)rand.Next('a', 'z' + 1);
            }
            Duration = rand.Next(60, 361);
            Quality = rand.Next(100, 1001);
            Size = Duration * Quality;
        }

        public override string ToString()
        {
            string result = "";
            result += $"Name - {Name}" + '\n';
            result += $"Size - {Size}" + '\n';
            result += $"Quality - {Quality}" + '\n';
            result += $"Duration - {Duration}" + '\n';
            return result;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                var rand = new Random();
                var arr = new VideoFile[rand.Next(5, 16)];
                for (var i = 0; i < arr.Length; i++)
                {
                    arr[i] = new VideoFile();
                    Console.WriteLine($"Video №{i + 1}: {arr[i]}");
                }

                Console.WriteLine("To exit press Escape.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}