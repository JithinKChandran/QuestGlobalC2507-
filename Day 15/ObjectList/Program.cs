using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectList
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person { Name = "Person 1", Country = "US", Age = 20 },
                new Person { Name = "Person 2", Country = "US", Age = 30 },
                new Person { Name = "Person 3", Country = "US", Age = 18 },
                new Person { Name = "Person 4", Country = "IN", Age = 20 }
            };

            //var res = data.Where(p => p.Country == "US");
            //foreach (var person in res)
            //{
            //    Console.WriteLine(person.Name);
            //}

            var minAge = data.Where(p => p.Country == "US").Min(p => p.Age);
            var youngest = data.Where(p => p.Country == "US" && p.Age == minAge).FirstOrDefault();
            Console.WriteLine(youngest.Name);

            var decAge = data.OrderByDescending(p => p.Age);
            var countries = data.Select(p => p.Country).Distinct();
            var dict = data.Select(p => new Dictionary<string, string>
            {
                {"Name", p.Name},
                {"Counntry", p.Country},
                {"Age", p.Age.ToString() }
            }).ToList();
        }
    }
}
