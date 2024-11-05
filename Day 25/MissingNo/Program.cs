using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 5};       
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            int res =  expectedSum - actualSum;
            Console.WriteLine($"Missing no: {res}");
        }
    }
}
