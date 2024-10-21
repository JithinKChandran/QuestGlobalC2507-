using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skip 5 and take next five and find the sum of even elements
            var data = new List<int>() {1 ,4, 2, 3, 4, 5, 6, 7 ,8};
            var sum = data.Skip(5).Take(5).Where(x => x % 2 == 0).Sum();
            Console.WriteLine(sum);
        }
    }
}
