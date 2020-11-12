using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson011_Task1
{
    class Garage
    {
        Vehicle[] vehicle;

        public Garage()
        {
            vehicle = new Vehicle[] { null };
        }
        public Garage(Vehicle[] vehicle)
        {
            this.vehicle = vehicle;
        }

        public Vehicle GetVehicle(int index)
        {
            Vehicle v1;
            if (index > this.vehicle.Length - 1 || index < 0)
            {
                Console.WriteLine("Wrong index!");
                v1 = null;
            }
            else
            {
                if (this.vehicle[index] != null)
                {
                    v1 = this.vehicle[index];
                    this.vehicle[index] = null;
                }
                else
                {
                    Console.WriteLine("There is no vehicle in the garage!");
                    v1 = null;
                }
            }
            return v1;
        }

        public void SetVehicle(int index, Vehicle vehicle)
        {
            if (index > this.vehicle.Length - 1 || index < 0)
            {
                Console.WriteLine("Wrong index!");
            }
            else
            {
                if (this.vehicle[index] == null)
                {
                    this.vehicle[index] = vehicle;
                }
                else
                    Console.WriteLine("There is a vehicle on this place!");
            }
        }
    }
}
