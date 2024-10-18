using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._9_10
{
    internal class Program
    {
        public static void x(Action<string> print)
        {
            print("Welcome");
        }

        public static void Sum(Action<int, int> print, int a, int b)
        {
            print(a, b);
        }
        static void Main(string[] args)
        {
            Action<string> msg = (message) => Console.WriteLine(message);
            x(msg);

            Action<int, int> printSum = (a, b) => Console.WriteLine($"sum: {a + b}");
            Sum(printSum, 5, 7);
        }
    }
}
