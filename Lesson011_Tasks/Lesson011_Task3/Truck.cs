using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson011_Task1
{
    class Truck : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Start truck");
        }
        public override void Stop()
        {
            Console.WriteLine("Stop truck");
        }

        /*
        private double weight;
        private double height;
        private double width;
        private double price;
        private double maxSpeed;

        public void Start()
        {

        }
        public void Stop()
        {

        }*/


    }
}
