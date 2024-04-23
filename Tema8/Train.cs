using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8
{
    public class Train
    {
        private string name;
        private List<Wagon> wagons = new List<Wagon>();
        private Locomotive locomotive;
        public string Name => name;
        public Train(string name, Locomotive locomotive)
        {
            this.name = name;
            this.locomotive = locomotive;
            
        }
        public void AddWagon(Wagon wagon)
        {
            wagons.Add(wagon);
            if (wagon is PassengerWagon passengerWagon)
            {
                Console.WriteLine($"{wagon.GetType().Name} : Number of Seats: {passengerWagon.NumberOfSeats}, Mass: {passengerWagon.Mass}, Year: {passengerWagon.YearOfManufacture}");
            }
            if (wagon is FreightWagon freightWagon)
            {
                Console.WriteLine($"{wagon.GetType().Name} : Cargo: {freightWagon.CargoType}, Capacity: {freightWagon.CapacityInTons} tons, Year: {freightWagon.YearOfManufacture}");
            }
        }

        public void DepartFromStation()
        {
            Console.WriteLine("Train departure:\n");
                    locomotive.Start();
        }

        public void ArriveAtStation()
        {
            Console.WriteLine("\nTrain arrival:\n");
            locomotive.Stop();
           
        }
        public int TotalNumberOfSeats()
        {
            int totalSeats = 0;
            foreach (var wagon in wagons)
            {
                if (wagon is PassengerWagon passengerWagon)
                {
                    totalSeats += passengerWagon.NumberOfSeats;
                }
                else if (wagon is FirstClass firstClassWagon)
                {
                    totalSeats += firstClassWagon.NumberOfSeats;
                }
            }
            return totalSeats;
        }
        public void ManageFirstClassAirConditioners(bool start)
        {
            if (start)
            {
                Console.WriteLine("Starting air conditioners in first class wagons");
            }
            else
            {
                Console.WriteLine("Stopping air conditioners in first class wagons");
            }

            foreach (var wagon in wagons)
            {
                if (wagon is FirstClass firstClassWagon)
                {
                    if (start)
                    {
                        firstClassWagon.StartAirConditioner();
                    }
                    else
                    {
                        firstClassWagon.StopAirConditioner();
                    }
                }
            }
        }
    }
}

