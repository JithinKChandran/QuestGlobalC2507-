using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._2Vehicle
{
    public class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(int speed, string model)
        {
            Speed = speed;
            Model = model;
        }

        public override void Drive()
        {
            Console.WriteLine($"Speed: {Speed} | Model: {Model}");
        }
    }
}
