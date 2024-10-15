using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionUpperCase
{
    internal class Program
    {
        static void ToUpperCase(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToUpper();
            }
        }

        static void Main(string[] args)
        {
            string[] names = new string[3];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name {i + 1}:");
                names[i] = Console.ReadLine();
            }
            ToUpperCase(names);

            Console.WriteLine("Result:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
