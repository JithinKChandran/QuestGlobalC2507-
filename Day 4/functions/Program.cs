using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {

        static void SingleLineAdd(int a, int b) => Console.WriteLine(a + b);

        static void SingleLineSub(int a, int b) => Console.WriteLine(a - b);

        static void Mul(int a, int b) => Console.WriteLine(a * b);

        static void SingleLineDiv(int a, int b) => Console.WriteLine(a / b);

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter an operation:");
                char opr = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());

                switch (opr)
                {
                    case '+':
                        Console.WriteLine("Result: " + Add(num1, num2));
                        break;
                    case '-':
                        Console.WriteLine("Result: " + Sub(num1, num2));
                        break;
                    case '*':
                        Console.WriteLine("Result: " + Mul(num1, num2));
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            Console.WriteLine("Result: " + Div(num1, num2));
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            }
        }
    }
}
