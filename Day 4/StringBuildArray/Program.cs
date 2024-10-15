using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuildArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "name1", "name2", "name3", "name4", "name5" };
            string[] results = new string[names.Length];

            int age = 0;
            foreach (string name in names)
            {
                results[age] = string.Format("{0} is {1} years old", name, age);
                age++;
            }

            string result = string.Join(", ", results);

            Console.WriteLine(result);
        }
    }
}
