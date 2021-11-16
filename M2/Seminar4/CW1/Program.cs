using System;

namespace CW1
{
    abstract class Animal
    {
         public string Sound
         {
             get;
             set;
         }

         public abstract string AnimalInfo();
    }

    class Dogs : Animal
    {
        public Dogs(int a) : base()
        {
            Sound = "GAV";
            if (a > 1)
            {
                IsGood = true;
            }
            else
            {
                IsGood = false;
            }

            Name = "Tankist";
        }
        
        public Dogs(int a, string name) : base()
        {
            Sound = "GAV";
            if (a > 1)
            {
                IsGood = true;
            }
            else
            {
                IsGood = false;
            }

            Name = name;
        }

        public bool IsGood
        {
            get;
            set;
        }
        
        public string Name
        {
            get;
            set;
        }
        
        public override string AnimalInfo()
        {
            string result = $"Is dog trained - {IsGood}." + '\n' + $"Dog say {Sound}." + '\n' + $"Name is {Name}.";
            return result;
        }

        public override string ToString()
        {
            return AnimalInfo();
        }
    }
    
    class Cows : Animal
    {
        public Cows(int a) : base()
        {
            Sound = "Muuuuuu";
            NumMilk = a;
        }

        public int NumMilk
        {
            get;
            set;
        }
        
        public override string AnimalInfo()
        {
            string result = $"Num of milk/day - {NumMilk}." + '\n' + $"Cow say {Sound}.";
            return result;
        }

        public override string ToString()
        {
            return AnimalInfo();
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myCow = new Cows(5);
            var myDog = new Dogs(3);
            Console.WriteLine(myDog);
            Console.WriteLine(myCow);
        }
    }
}