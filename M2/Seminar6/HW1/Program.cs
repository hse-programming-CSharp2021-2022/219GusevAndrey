using System;
using System.IO;
using System.Runtime.Serialization;

namespace HW1
{
    class WrongNameException : Exception
    {
        public WrongNameException()
        {
        }

        public WrongNameException(string message) : base(message) 
        {
        }

        public WrongNameException(string message, Exception innerException) : base (message, innerException)
        {
        }
        
        protected WrongNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public string AdditionalInfo { get; set; }
        public override string Message => "Такое имя нельзя произносить!!!";
    }
    
    class Pain : Exception
    {
        public Pain()
        {
        }

        public Pain(string message) : base(message) 
        {
        }

        public Pain(string message, Exception innerException) : base (message, innerException)
        {
        }
        
        protected Pain(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public string AdditionalInfo { get; set; }
        public override string Message => "10 ошибка!!!";
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            ///first
            try
            {
                int n = 0;
                int a = 10 / n;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("/ 0");
            }
            ///second
            try
            {
                var arr = new int[5];
                arr[8] = 10;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range!!!");
            }
            ///third
            try
            {
                int[] arr = null;
                arr[0] = 12;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            ///fourth
            try
            {
                File.Copy("123","123");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            ///fifth
            try
            {
                Directory.Delete("qwe12321");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            ///sixth
            try
            {
                string[] names = {"1", "2", "3"};
                Object[] objs  = (Object[])names;
                objs[2] = 12;
            }
            catch (ArrayTypeMismatchException)
            {
                Console.WriteLine("Type mismatch!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            ///seventh
            try
            {
                var a = int.Parse("123asdasd");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            ///eighth
            try
            {
                string strangeQuestion = "What is Dark Lord's name?";
                string HarrySay = "Wolan de Mort";
                if (strangeQuestion == "Wolan de Mort" || HarrySay == "Wolan de Mort")
                    throw new WrongNameException();
            }
            catch (WrongNameException e)
            {
                Console.WriteLine($"{e.Message}!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            ///nineth
            try
            {
                checked
                {
                    byte value = 241;
                    sbyte newValue = (sbyte) value;
                    
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Overflow!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            ///tenth
            try
            {
                int num = 10;
                if (num == 10)
                    throw new Pain();
            }
            catch (Pain e)
            {
                Console.WriteLine($"{e.Message}!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}