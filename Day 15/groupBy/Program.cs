using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupBy
{
    public class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public override string ToString() => $"Name: {Name}, Country: {Country}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>
        {
            new Person { Name = "Person 1", Country = "IN"},
            new Person { Name = "Person 1", Country = "IN" },
            new Person { Name = "Person 2", Country = "US"},
            new Person { Name = "Person 3", Country ="CA"},
            new Person { Name = "Person 4", Country = "IN" }
        };

            var groups = data.GroupBy(p => p.Country);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
                foreach (var person in group)
                {
                    Console.WriteLine($"\t{person}");
                }
            }
        }
    }
}
