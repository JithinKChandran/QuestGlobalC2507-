using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    internal class Smartphone
    {
        public string Name;
        public string Manufacturer;
        public List<int> RamSizes;

        public void Display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Manufacturer : {Manufacturer}");

            foreach (var item in RamSizes)
            {
                Console.WriteLine($"Ram sizes availabe are : {item}");
            }
        }
    }
}
