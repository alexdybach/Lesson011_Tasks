using Lesson011_Task1;
using System;

namespace Lesson011_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicle = new Vehicle[6];

            Car dodge = new Car();
            dodge.Height = 1.73;
            dodge.Weight = 2214;
            dodge.Width = 1.97;
            dodge.Price = 44390;
            dodge.MaxSpeed = 367.9;

            //dodge.Start();
            //dodge.Stop();

            Truck truck = new Truck();
            truck.Height = 3.4;
            truck.Weight = 10321;
            truck.Width = 2.7;
            truck.Price = 49390;
            truck.MaxSpeed = 207.1;

            //truck.Start();
            //truck.Stop();

            Bus bus = new Bus();
            bus.Height = 2.83;
            bus.Weight = 8214;
            bus.Width = 3.1;
            bus.Price = 63290;
            bus.MaxSpeed = 127.9;

            //bus.Start();
            //bus.Stop();

            Bicycle bicycle = new Bicycle();
            bicycle.Height = 1;
            bicycle.Price = 231;
            bicycle.MaxSpeed = 40;
            bicycle.Weight = 2;
            bicycle.Width = 20;

            //bicycle.Start();
            //bicycle.Stop();


            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Height = 1;
            motorcycle.Price = 2103;
            motorcycle.MaxSpeed = 250;
            motorcycle.Weight = 1000;
            motorcycle.Width = 2;

            //motorcycle.Start();
            //motorcycle.Stop();

            Plane plane = new Plane();
            plane.Height = 30;
            plane.Price = 1283758.23;
            plane.MaxSpeed = 1800;
            plane.Weight = 30_000;
            plane.Width = 30;

            //plane.Start();
            //plane.Stop();

            vehicle[0] = dodge;
            vehicle[1] = bicycle;
            vehicle[2] = bus;
            vehicle[3] = motorcycle;
            vehicle[4] = plane;
            vehicle[5] = truck;

            //for (int i = 0; i < vehicle.Length; i++)
            //{
            //    vehicle[i].Start();
            //    vehicle[i].Stop();
            //    Console.WriteLine();
            //}
            Console.WriteLine("**  Garage 1  **");
            Garage garage1 = new Garage(vehicle);

            Vehicle vehicle1 = garage1.GetVehicle(2);
            vehicle1.Start();
            vehicle1.Stop();
            garage1.SetVehicle(2, vehicle1);


            Console.WriteLine("\n**  Garage 2  (empty) **");
            Garage garage2 = new Garage();
            Vehicle vehicle2 = garage2.GetVehicle(0);
            garage2.SetVehicle(2, vehicle2);

            Console.WriteLine("\n**  Garage 3  **");
            Garage garage3 = new Garage(vehicle);

            Vehicle vehicle3 = garage1.GetVehicle(5);
            vehicle3.Start();
            vehicle3.Stop();
            garage1.SetVehicle(2, vehicle3);
        }
    }
}
