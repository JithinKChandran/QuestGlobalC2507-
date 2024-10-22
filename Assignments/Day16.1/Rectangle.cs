using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16._1
{
    class Rectangle : IShape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public  double GetArea() => Length * Width;
        public  double GetPerimeter() => 2 * (Length + Width);
    }
}
