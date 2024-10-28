using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes
namespace BenchMark
{
    public class ArrayAndSpan
    {
        [BenchMark]
        public void TestList()
        {
            var lst = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lst.Add(i);
            }
        }

        [BenchMark]
        public void TestArray()
        {
            var arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ArrayAndSpan>();
        }
    }
}
