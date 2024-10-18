using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._2Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle nc = new Car(80, "SUV");
            Vehicle nb = new Bicycle(20, "Hero");
            nc.Drive();
            nb.Drive(); 
        }
    }
}
