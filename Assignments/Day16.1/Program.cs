using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new Circle { Radius = 5 },
                new Rectangle { Length = 4, Width = 7 }
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}, Perimeter: {shape.GetPerimeter()}");
            }
        }
    }
}
