using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._1Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 5);

            Console.WriteLine($"Circle: {circle.Area()} | Rectangle: {rectangle.Area()}");
        }
    }
}
