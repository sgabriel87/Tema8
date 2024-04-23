using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8
{
    public class FirstClass : PassengerWagon
    {
        public bool AirConditioner { get; private set; }
        public FirstClass(int numberOfSeats, double mass, int year, bool airConditioner)
        : base(numberOfSeats, mass, year)
        {
            AirConditioner = airConditioner;

        }
        public void StartAirConditioner()
        {
            AirConditioner = true;
            Console.WriteLine("Air conditioner started.");
        }
        public void StopAirConditioner()
        {
            AirConditioner = false;
            Console.WriteLine("Air conditioner stopped.");
        }
    }
}

