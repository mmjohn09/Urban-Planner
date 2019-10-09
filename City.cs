using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        private string _name = "Megatropolis";
        private string _mayor = "Maggie Johnson";
        private int _yearEstablished;
        public List<Building> Buildings = new List<Building>();
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
        public City()
        {
            _yearEstablished = DateTime.Now.Year;
        }
        public void PrintCity()
        {
            Console.WriteLine($"City Name: {_name}");
            Console.WriteLine($"Established: {_yearEstablished}");
            Console.WriteLine($"Mayor: {_mayor}");
        }
    }
}