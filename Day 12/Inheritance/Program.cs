using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        string DataA { get; set; }

        public void MethodA() => Console.WriteLine("From class A");
    }

    class B: A
    {
        string DataB { get; set; }

        //public void MethodA() => Console.WriteLine("A From class b");

        //to access parent class use base**

        //new public void MethodA()
        //{
        //    Console.WriteLine("A From class B");
        //    base.MethodA();
        //}

        public void MethodB() => Console.WriteLine("B From class b");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new B();
            c.MethodA();
            c.MethodB();
        }
    }
}
