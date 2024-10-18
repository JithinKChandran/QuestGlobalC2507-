using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._4Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calc = new SimpleCalculator();
            int sum = calc.Add(2, 3);
            int dif = calc.Sub(10, 1);
            Console.WriteLine($"Sum: {sum} | Difference: {dif}");
        }
    }
}
