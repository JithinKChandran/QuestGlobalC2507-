using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeDelegate
{
    internal class Program
    {
        delegate void TaskDelegate();
        static void StartTime(int sec, TaskDelegate task)
        {
            Console.WriteLine("Timer started");
            Thread.Sleep(sec * 1000);
            task();
        }

        static void GreetAfterTenSecnds()
        {
            Console.WriteLine("hello from c#");
        }
        static void Main(string[] args)
        {
            StartTime(10, GreetAfterTenSecnds);
        }
    }
}
