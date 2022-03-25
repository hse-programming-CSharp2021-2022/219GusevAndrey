using System;
using System.Text;
namespace HW1
{
    public struct Person : IComparable<Person>
    {
        private string _name;
        private string _surname;
        private int _age;
        
        public string Name
        {
            get
            {
               return _name; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Ошибка!");
                _name = value;
            }
        }
        
        public string Surname
        {
            get
            {
                return _surname;
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Ошибка!");
                _surname = value;
            }
        }
        
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("", "Ошибка!");
                _age = value;
            }
        }
        
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int CompareTo(Person person)
        {
            if (Age > person.Age) 
                return 1;
            if (Age == person.Age)
                return 0; 
            return -1;
        }

        public override string ToString() => $"Имя: {Name}. \n" +
                                             $"Фамилия: {Surname}. \n" +
                                             $"Возраст: {Age}.";
    }

    class Program
    {
        static void Main()
        {
            Random random = new Random();
            string[] name = { "Иван", "Анна", "Михаил", "Артем", "Антон"};
            string[] surname =  { "Иванов", "Сидоров", "Попов", "Петров"};
            int n = int.Parse(Console.ReadLine());
            Person[] characters = new Person[n];
            for (int i = 0; i < n; i++)
            {
                characters[i] = new Person(name[random.Next(name.Length)], surname[random.Next(surname.Length)], random.Next(1, 101));
            }
            Array.ForEach(characters, el => Console.WriteLine(el));
            Array.Sort(characters);
            Array.ForEach(characters, el => Console.WriteLine(el));
        }
    }
}