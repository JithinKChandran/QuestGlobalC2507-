using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchUserById
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("Enter add to add marks or search to find the user or q to exit:");
                var c = Console.ReadLine().ToLower();

                if (c == "q")
                {
                    break;
                }
                else if (c == "add")
                {
                    Console.WriteLine($"Enter student id of student or q to exit");
                    var id = Console.ReadLine();

                    if (data.ContainsKey(id))
                    {
                        Console.WriteLine($"Student ID {id} already exists. Do you want to overwrite the marks? (y/n)");
                        var response = Console.ReadLine().ToLower();

                        if (response == "n")
                        {
                            continue;
                        }
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
                else if (c == "search")
                {
                    Console.WriteLine("Enter student ID to search:");
                    var sid = Console.ReadLine();

                    if (data.ContainsKey(sid))
                    {
                        Console.WriteLine($"Student ID {sid}: {data[sid]}");
                    }
                    else
                    {
                        Console.WriteLine("Not found.");
                    }
                }
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
