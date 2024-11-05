using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDel
{
    public delegate void Display();

    class Program
    {
        static void Main(string[] args)
        {
            Display display = Method1;
            display += Method2;

            display();
        }

        static void Method1()
        {
            Console.WriteLine("Method1.");
        }

        static void Method2()
        {
            Console.WriteLine("Method2.");
        }
    }
}