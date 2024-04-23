using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8
{
    public class Wagon
    {
        public double Mass { get; private set; }
        public int YearOfManufacture { get; private set; }

        public Wagon(double mass, int year)
        {
            Mass = mass;
            YearOfManufacture = year;
        }

        public static void CloseDoors()
        {
            Console.WriteLine("Doors closed.");
        }

        public static void OpenDoors()
        {
            Console.WriteLine("Doors opened.");
        }
    }

}
