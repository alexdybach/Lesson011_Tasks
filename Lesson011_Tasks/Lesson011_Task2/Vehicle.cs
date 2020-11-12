using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson011_Task1
{
    class Vehicle
    {
        private double weight;
        private double height;
        private double width;
        private double price;
        private double maxSpeed;

        public double Height   { get; set; }
        public double Width    { get; set; }
        public double Weight   { get; set; }
        public double Price    { get; set; }
        public double MaxSpeed { get; set; }

        

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
