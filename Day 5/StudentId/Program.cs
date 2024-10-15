using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentId
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine($"Enter student id of student or q to exit");
                var id = Console.ReadLine();

                if (id == "q")
                {
                    break;
                }

                Console.WriteLine($"Enter the number of subjects for Student {id}: ");
                int sub = int.Parse(Console.ReadLine());

                var mark = new List<int>();
                for (int j = 0; j < sub; j++)
                {
                    Console.Write($"Mark {j + 1}: ");
                    mark.Add(int.Parse(Console.ReadLine()));
                }

                data[id] = string.Join(", ", mark);
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
