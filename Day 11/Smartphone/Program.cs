using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartPhone = new Smartphone();
            smartPhone.Name = "iphone";
            smartPhone.Manufacturer = "Google";
            smartPhone.RamSizes = new List<int>() { 8, 16 };

            
            Smartphone smartPhone2 = new Smartphone()
            {
                Name = Console.ReadLine() ,
                Manufacturer = Console.ReadLine(),
                RamSizes = new List<int>() { 8, 16, 32 }
            };

            smartPhone.Display();
            smartPhone2.Display();
        }
    }
}
