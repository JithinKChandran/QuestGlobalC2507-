using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._13Appliance
{
    public abstract class Appliance
    {
        public abstract void TurnOn();
    }

    public class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("ON");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance fan = new Fan();
            fan.TurnOn();
        }
    }
}
