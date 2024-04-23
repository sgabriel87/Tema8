using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8
{
    public class FreightWagon : Wagon
    {
        public string CargoType { get; private set; }
        public double CapacityInTons { get; private set; }

        public FreightWagon(string cargoType, double capacityInTons, double mass, int year) : base(mass, year)
        {
            CargoType = cargoType;
            CapacityInTons = capacityInTons;
        }
    }

}



