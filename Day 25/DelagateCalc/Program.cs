using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateCalc
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> multiply = (x, y) => x * y;

            int res1 = Calculate(5, 3, add);
            int res2 = Calculate(5, 3, multiply);

            Console.WriteLine("Sum: " + res1); 
            Console.WriteLine("Produt: " + res2); 
        }

        static int Calculate(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }
    }
}