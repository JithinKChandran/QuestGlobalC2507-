using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static void Action()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Hello 1");
        }
        static void Action2()
        {
            Console.WriteLine("Hello 2");
        }
        static void Main(string[] args)
        {
            var t1 = new Thread(Action);
            var t2 = new Thread(Action2);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Completed");
        }
    }
}
