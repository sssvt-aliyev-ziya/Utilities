using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    class Doors
    {
        public double width;
        public double height;
        public bool isDoubleWinged;
        public Doors(double width, double height, bool isDoubleWinged)
        {
            this.width = width;
            this.height = height;
            this.isDoubleWinged = isDoubleWinged;
        }
        public void WriteDoor(Doors door)
        {
            Console.Write($"Šířka: {door.width}, výška: {door.height} ");
            if (door.isDoubleWinged)
            {
                Console.WriteLine("dvoukřídlé");
            }
            else
            {
                Console.WriteLine("jednokřídlé");
            }
        }
    }
}