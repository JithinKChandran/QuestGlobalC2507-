using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubAdd
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point()
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = a + b;

            var p1 = new Point() { X = 1, Y = 2 };
            var p2 = new Point() { X = 3, Y = 4 };
            var p3 = p1 + p2;   
        }
    }
}
