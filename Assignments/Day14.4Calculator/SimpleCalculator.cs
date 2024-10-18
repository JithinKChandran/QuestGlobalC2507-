using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._4Calculator
{
    public class SimpleCalculator : ICalculator
    {
        public int Add(int a , int b) => a + b;
        public int Sub(int a , int b) => a - b;
    }
}
