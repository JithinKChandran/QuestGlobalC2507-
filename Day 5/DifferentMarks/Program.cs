using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>[3];

            for (int i = 0; i < 2; i++)
            {
                data[i] = new List<int>();
                Console.WriteLine($"Enter mark of student {i + 1}:");
                Console.WriteLine("Enter number of marks:");

                int numberOfMarks = int.Parse(Console.ReadLine());
                for (int j = 0; j < numberOfMarks; j++)
                {
                    Console.Write($"Mark {j + 1}:");
                    data[i].Add(int.Parse(Console.ReadLine()));
                }
            }
            foreach (var marks in data)
            {
                Console.WriteLine(string.Join(", ", marks));
            }
            Console.ReadKey();
        }
    }
}
