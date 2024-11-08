using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPrg
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point();
            var p2 = p1;
            p2.X = 10;
            Console.WriteLine(p1.X);
        }
    }
}
