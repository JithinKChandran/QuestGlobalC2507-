using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._5Operations
{
    public delegate int Operations(int a,  int b);  
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Operations addOperations = new Operations(calculator.Add);
            Operations multiplyOperations = new Operations(calculator.Mul);

            int addRes = addOperations(3, 4);
            int mulRes = multiplyOperations(3, 4);
            Console.WriteLine($"Add: {addRes} | Product: {mulRes}");
        }
    }
}
