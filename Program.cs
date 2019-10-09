using System;
using System.Collections.ObjectModel;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building buildingOne = new Building("123 Oak Street");

            buildingOne.Stories = 3;
            buildingOne.Width = 25.1;
            buildingOne.Depth = 35.4;
            buildingOne.Construct();
            buildingOne.Purchase("Joe Smith");

            Building buildingTwo = new Building("456 Elm Avenue");

            buildingTwo.Stories = 25;
            buildingTwo.Width = 75.6;
            buildingTwo.Depth = 64.3;
            buildingTwo.Construct();
            buildingTwo.Purchase("Mary Jones");

            Building buildingThree = new Building("789 Maple Boulevard");

            buildingThree.Stories = 12;
            buildingThree.Width = 45.8;
            buildingThree.Depth = 39.5;
            buildingThree.Construct();
            buildingThree.Purchase("Sue Green");

            buildingOne.PrintBuilding();
            buildingTwo.PrintBuilding();
            buildingThree.PrintBuilding();
            
        }
    }
}

