using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class MyClass
    {
        public string Name { get; private set; }
        public void SetValue()
        {
            Name = "New Name";
        }
    }
    internal class Program
    {
        //static void Add(int i, int j, params int[] array)
        //{
        //    Console.WriteLine(array.Sum() + i + j);
        //}
        static void Main(string[] args)
        {
            //Add(3, 4, 5, 6);

            var n = new MyClass()
            {
                // Name = "Test"
            };
            
            Console.WriteLine(n.Name);
        }
    }
}
