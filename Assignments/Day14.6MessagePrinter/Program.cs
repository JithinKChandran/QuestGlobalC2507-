using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._6MessagePrinter
{
    public delegate void PrintMessage(string message);

    public class MessagePrinter
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MessagePrinter printer = new MessagePrinter();
            PrintMessage print = new PrintMessage(printer.Display);
            print("Hello");
        }
    }
}
