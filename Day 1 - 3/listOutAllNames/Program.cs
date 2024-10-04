using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listOutAllNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Ram", "Bob", "Jane", "Sam" };

            Console.WriteLine("Enter a name to search:");
            var toSearch = Console.ReadLine().ToLower().Trim();

            bool found = false;

            for (int i = 0; i < names.Length; i++)
            {
                var n = names[i].ToLower();
                if (n.Contains(toSearch))
                {
                    Console.WriteLine("Name found: " + names[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No names found.");
            }
        }
    }
}
