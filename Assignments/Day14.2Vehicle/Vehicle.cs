using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._2Vehicle
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }

        public abstract void Drive();
    }
}
