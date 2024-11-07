using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackUsingList stack = new StackUsingList();

            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Display();

            Console.WriteLine($"Peeked value: {stack.Peek()}");

            stack.Pop();
            stack.Display();
        }
    }
}
