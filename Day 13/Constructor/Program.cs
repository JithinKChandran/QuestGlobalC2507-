using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class MyClass
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public string[] PhoneNumber { get; set; }
        // default constructor
        public MyClass(int phoneNumbetCount)
        {
            CreatedAt = DateTime.Now;
            PhoneNumber = new string[phoneNumbetCount];
            Console.WriteLine("Constructor was called.");
        }

        public MyClass(string name, int phoneNumberCount)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            PhoneNumber = new string[phoneNumberCount];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass(2);
            var obj1 = new MyClass("Jithin", 2);
        }
    }
}
