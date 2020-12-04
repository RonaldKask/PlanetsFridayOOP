using System;
using System.Collections.Generic;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        public class Planet
        {
            string planet;
            int mass;

            public Planet(string _name, int _mass)
            {
                planet = _name;
                mass = _mass;
            }

            public string Name { get { return planet; } }

            public int Price { get { return mass; } }
        }
        static void Main(string[] args)
        {
            InnerPlanetList();
            OuterPlanetList();
        }

        public static void InnerPlanetList()
        {
            List<string> planetList = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter planet name: ");
                string planet = Console.ReadLine();
                Console.WriteLine("Enter mass: ");
                string mass = Console.ReadLine();

                string line = $"{planet}${mass}";
                planetList.Add(line);

                string filePath = @"C:\Users\opilane\samples";
                string fileName = @"innerplanets.txt";
                File.WriteAllLines(Path.Combine(filePath, fileName), planetList);
            }
        }

        public static void OuterPlanetList()
        {
            List<string> planetList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter planet name: ");
                string planet = Console.ReadLine();
                Console.WriteLine("Enter mass: ");
                string mass = Console.ReadLine();

                string line = $"{planet}${mass}";
                planetList.Add(line);

                string filePath = @"C:\Users\opilane\samples";
                string fileName = @"outerplanets.txt";
                File.WriteAllLines(Path.Combine(filePath, fileName), planetList);
            }
        }
    }
}
