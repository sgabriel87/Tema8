using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8
{
    public class PassengerWagon : Wagon
    {
        public int NumberOfSeats { get; protected set; }
        
        public PassengerWagon(int numberOfSeats, double mass, int year) : base(mass, year)
        {
            NumberOfSeats = numberOfSeats;
            
        }
       
    }
}

