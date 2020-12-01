using System;
using UtilitiesMain.MethodExtraction.Example;
using UtilitiesMain.MethodExtraction.Exercise;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeHouse();

            static House MakeHouse()
            {
                Window leftWindow = new Window("Standard", 0.8, 1.5);
                Window topWindow = new Window("Standard", 0.8, 1.5);
                Window rightWindow = new Window("French", 1, 2.2);
                Doors insideDoor = new Doors(0.9, 2.2, false);
                Doors outsideDoor = new Doors(1.8, 2.1, true);

                House house = new House();
                house.width = 0.5;
                house.height = 3.2;
                house.door = outsideDoor;
                house.window = leftWindow;
                house.window2 = topWindow;

                Console.WriteLine($"Width of the house: {house.width}, ");
                Console.WriteLine($"Height of the house: {house.height}, ");
                Console.WriteLine($"Width of the door: {house.door.width}, Height of the door: {house.door.height}, Type: {(house.door.isDoubleWinged ? "doubled":"single")}");
                Console.WriteLine($"Width of the door: {house.window.width}, Height of the door: {house.window.height}, Type: {house.window.model}");
                Console.WriteLine($"Width of the door: {house.window2.width}, Height of the door: {house.window2.height}, Type: {house.window2.model}");

                return house;
            }

            Console.ReadKey(true);
        }
    }
}
