using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    internal class Program
    {
        static void Greet() => Console.WriteLine("Greetings from C#");
        static void GreetWithMessage(string message) => Console.WriteLine(message);
        static void Add(int a, int b) => Console.WriteLine(a + b);
        static void Main(string[] args)
        {
            //Action (no return value) 
            Action g = Greet;
            Action<string> gm = GreetWithMessage;
            Action<int, int> a = Add;

            g();
            gm("hello");
            a(1,2);
            
        }
        
    }
}
