using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson011_Task1
{
    class Vehicle
    {
        public double weight;
        public double height;
        public double width;
        public double price;
        public double maxSpeed;

        public void Start()
        {
            Console.WriteLine("Start engine");
        }
        public void Stop()
        {
            Console.WriteLine("Stop engine");
        }
    }
}
