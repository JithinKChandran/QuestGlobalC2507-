using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<List<int>>();

            for (int i = 0; i < 2; i++)
            {
                var marks = new List<int>();
                Console.WriteLine($"Enter mark of student {i + 1}:");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Mark {j + 1}:");
                    marks.Add(int.Parse(Console.ReadLine()));
                }
                data.Add(marks);
            }
            foreach (var marks in data)
            {
                Console.WriteLine(string.Join(", ", marks));
            }
            Console.ReadKey();
        }
    }
}
