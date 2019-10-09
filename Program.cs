using System;
using System.Collections.ObjectModel;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Megatropolis = new City();
            Building buildingOne = new Building("123 Oak Street");

            buildingOne.Stories = 3;
            buildingOne.Width = 25.1;
            buildingOne.Depth = 35.4;
            buildingOne.Construct();
            buildingOne.Purchase("Joe Smith");
            Megatropolis.AddBuilding(buildingOne);

            Building buildingTwo = new Building("456 Elm Avenue");

            buildingTwo.Stories = 25;
            buildingTwo.Width = 75.6;
            buildingTwo.Depth = 64.3;
            buildingTwo.Construct();
            buildingTwo.Purchase("Mary Jones");
            Megatropolis.AddBuilding(buildingTwo);

            Building buildingThree = new Building("789 Maple Boulevard");

            buildingThree.Stories = 12;
            buildingThree.Width = 45.8;
            buildingThree.Depth = 39.5;
            buildingThree.Construct();
            buildingThree.Purchase("Sue Green");
            Megatropolis.AddBuilding(buildingThree);

            Megatropolis.PrintCity();
            
            foreach (Building building in Megatropolis.Buildings)
            {
                building.PrintBuilding();
            }

        }
    }
}

