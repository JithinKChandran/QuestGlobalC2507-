using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._11_12Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = (num) => num % 2 == 0;

            Console.WriteLine($"Is 4 even? {isEven(4)} | Is 7 even? {isEven(7)}");

            Predicate<string> startsWithA = (str) => str.StartsWith("A");

            Console.WriteLine($"Apple start with A? {startsWithA("Apple")}"); 
        }
    }
}
