using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4 };
            var firstHalf = num.Take(num.Length / 2).Reverse().ToArray();
            var secondHalf = num.Skip(num.Length / 2).Reverse().ToArray();
            firstHalf.CopyTo(num, 0);
            secondHalf.CopyTo(num, num.Length / 2);
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
