using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16._1
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
        public double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
