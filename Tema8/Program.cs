// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Tema8;


Locomotive locomotive = new Locomotive();
Train train = new Train("T-586413", locomotive);
Console.WriteLine($"Train: Name - {train.Name}\n");


train.AddWagon(new PassengerWagon(50, 10000, 2010));
train.AddWagon(new PassengerWagon(40, 9000, 2012));
train.AddWagon(new FirstClass(50, 5000, 2011, true));
train.AddWagon(new FirstClass(50, 5000, 2011, true));
train.AddWagon(new FreightWagon("Cereals", 20, 15000, 2015));
train.AddWagon(new FreightWagon("Coal", 30, 11000, 2018));
train.AddWagon(new FreightWagon("Steel", 40, 28000, 2020));


int totalSeats = train.TotalNumberOfSeats();
Console.WriteLine($"Total number of seats: {totalSeats}\n");

train.DepartFromStation();
Wagon.CloseDoors();
train.ManageFirstClassAirConditioners(true);
Console.WriteLine("Train traveling...");
train.ArriveAtStation();
Wagon.OpenDoors();
train.ManageFirstClassAirConditioners(true);




