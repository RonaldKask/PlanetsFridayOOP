using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PlanetsFridayOOP
{
    class Program
    {
        public class Planet
        {
            string name;
            int mass;

            public Planet(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }

            public string Name { get { return name; } }

            public int Mass { get { return mass; } }


        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"planets.txt";
            List<Planet> planetList = new List<Planet>();
            List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach (string line in linesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                Planet newItem = new Planet(tempArray[0], Int32.Parse(tempArray[1]));
                planetList.Add(newItem);
            }

            Console.WriteLine("Planet total mass:");
            int total = 0;

            foreach (Planet planet in planetList)
            {
                Console.WriteLine($"Planets: {planet.Name}, mass: {planet.Mass}");
                total += planet.Mass;
            }

            Console.WriteLine($"The planet total price is: {total}");
        }
    }
}