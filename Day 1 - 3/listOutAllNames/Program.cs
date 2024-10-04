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
            var toSearch = Console.ReadLine().ToLower().Trim();

            for (int i = 0; i < names.Length; i++)      
            {
                var n = names[i].ToLower();
                if (n.Contains(toSearch.ToLower()))
                {
                    Console.WriteLine("Names found");
                }
            }

        }
    }
}
