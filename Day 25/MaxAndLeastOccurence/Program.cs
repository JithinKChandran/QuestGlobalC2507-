using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndLeastOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello world world of programming programming hello world";

            var result = input.ToLower()
                              .GroupBy(c => c);

            var most = result.OrderByDescending(g => g.Count()).First();
            var least = result.OrderBy(g => g.Count()).First();

            Console.WriteLine($"Most : {most.Key} : {most.Count()} ");
            Console.WriteLine($"Least : {least.Key} : {least.Count()} ");
        }
    }
}
