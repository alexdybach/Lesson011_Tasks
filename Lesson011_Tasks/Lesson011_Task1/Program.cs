using System;

namespace Lesson011_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car dodge = new Car();
            dodge.height = 1.73;
            dodge.weight = 2214;
            dodge.width = 1.97;
            dodge.price = 44390;
            dodge.maxSpeed = 367.9;

            dodge.Start();
            dodge.Stop();
            
            Truck truck = new Truck();
            truck.height = 3.4;
            truck.weight = 10321;
            truck.width = 2.7;
            truck.price = 49390;
            truck.maxSpeed = 207.1;

            truck.Start();
            truck.Stop();
            
            Bus bus = new Bus();
            bus.height = 2.83;
            bus.weight = 8214;
            bus.width = 3.1;
            bus.price = 63290;
            bus.maxSpeed = 127.9;

            bus.Start();
            bus.Stop();

            Bicycle bicycle = new Bicycle();
            bicycle.height = 1;
            bicycle.price = 231;
            bicycle.maxSpeed = 40;
            bicycle.weight = 2;
            bicycle.width = 20;

            bicycle.Start();
            bicycle.Stop();


            Motorcycle motorcycle = new Motorcycle();
            motorcycle.height = 1;
            motorcycle.price = 2103;
            motorcycle.maxSpeed = 250;
            motorcycle.weight = 1000;
            motorcycle.width = 2;

            motorcycle.Start();
            motorcycle.Stop();

            Plane plane = new Plane();
            plane.height = 30;
            plane.price = 1283758.23;
            plane.maxSpeed = 1800;
            plane.weight = 30_000;
            plane.width = 30;

            plane.Start();
            plane.Stop();

        }
    }
}
