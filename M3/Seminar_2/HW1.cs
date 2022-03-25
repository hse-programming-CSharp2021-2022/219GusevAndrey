/*
 Класс Plant. Закрытые вещественные поля: рост (growth), светочувствительность(photosensitivity) и морозоустойчивость(frostresistance).
 */
using System;
namespace HW1
{
    class Plant
    {
        private double _growth; 
        private double _photosensiuvity; 
        private double _frostresistance; 

        public double Growth
        {
            get { return _growth; }
            set { _growth = value; }
        }

        public double Photosensiuvity
        {
            get { return _photosensiuvity; }
            set
            {
                if (value >= 0 && value <= 100)
                    _photosensiuvity = value;
                else _photosensiuvity = 0;
            }
        }

        public double Frostresistance
        {
            get { return _frostresistance; }
            set
            {
                if (value >= 0 && value <= 100)
                    _frostresistance = value;
                else _frostresistance = 0;
            }
        }

        public Plant(double growth, double photosensiuvity, double frostresistance)
        {
            Growth = growth;
            Photosensiuvity = photosensiuvity;
            Frostresistance = frostresistance;
        }

        public override string ToString() =>
            $"Growth: {Growth}, Photosensivity: {Photosensiuvity}, Frostresistance: {Frostresistance}.";

    }

    
    class Program
    {
        public static int Swap(Plant x, Plant y) => ((int) x.Photosensiuvity  == (int) y.Photosensiuvity) ? x.Photosensiuvity.CompareTo(y.Photosensiuvity) : (int) x.Photosensiuvity.CompareTo((int) y.Photosensiuvity);

        public static void Print(Plant[] arrayPlants) => Array.ForEach(arrayPlants, plant => Console.WriteLine(plant));

        static void Main(string[] args)
        {
            var random = new Random();
            int n; 
            int.TryParse(Console.ReadLine(), out  n)
            Plant[] arrayPlants = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                arrayPlants[i] = new Plant((double) random.Next(25,101), (double) random.Next(0,101), (double) random.Next(0,81));
            }

            Print(arrayPlants);
            Console.WriteLine();
            
            Array.Sort(arrayPlants, delegate(Plant plant, Plant plant1) { return plant.Growth > plant1.Growth ? -1 : 1; });
            Print(arrayPlants);
            Console.WriteLine();
            

            Array.Sort(arrayPlants, (plant, plant1) => plant.Growth < plant1.Growth ? -1 : 1);
            Print(arrayPlants);
            Console.WriteLine();
            

            Array.Sort(arrayPlants, Swap);
            Print(arrayPlants);
            Console.WriteLine();
            

            Array.ConvertAll(arrayPlants, plant => plant.Frostresistance = (plant.Frostresistance % 2 == (0) )? plant.Frostresistance / 3 : plant.Frostresistance / 2);
            Print(arrayPlants);
            Console.WriteLine();
        }
    }
}