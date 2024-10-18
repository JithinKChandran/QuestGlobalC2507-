using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._7Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(1, 2);
            Func<string, int> getLength = (input) => input.Length;
            string x = "Hello";
            int length = getLength(x);
            Console.WriteLine($"{result} | {x}");
        }
    }
}
