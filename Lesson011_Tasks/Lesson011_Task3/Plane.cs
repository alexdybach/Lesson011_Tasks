using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson011_Task1
{
    class Plane : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Start plane");
        }
        public override void Stop()
        {
            Console.WriteLine("Stop plane");
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
