
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    internal class Calculator
    {
        //public int Num1;
        //public int Num2;
        //public string Operator;
        private int Num1;
        private int Num2;

        public void Add() => Console.WriteLine($"Sum is {Num1 + Num2}");
        public void Sub() => Console.WriteLine($"Sub is {Num1 - Num2}");
        public void Mul() => Console.WriteLine($"Mul is {Num1 * Num2}");
        public void Div() => Console.WriteLine($"Div is {Num1 / Num2}");


        public void Run()
        {

            Console.Write("Enter num1 :");
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 :");
            Num2 = int.Parse(Console.ReadLine());

            Add();
            Sub();
            Mul();
            Div();
        }
    }
}
