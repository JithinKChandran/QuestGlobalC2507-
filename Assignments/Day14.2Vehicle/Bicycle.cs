using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._2Vehicle
{
    public class Bicycle : Vehicle
    {
        public string Type { get; set; }

        public Bicycle(int speed, string type)
        {
            Speed = speed;
            Type = type;
        }

        public override void Drive()
        {
            Console.WriteLine($"Speed: {Speed} | Type: {Type}");
        }
    }
}
