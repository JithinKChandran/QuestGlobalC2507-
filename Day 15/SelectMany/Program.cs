using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    public class Person
    {
        public string Name { get; set; }
        public string[] Emails { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>
        {
            new Person { Name = "Person 1", Emails = new[] { "a@gmail.com", "a@outlook.com" } },
            new Person { Name = "Person 1", Emails = new[] { "b@gmail.com", "b@outlook.com" } },
            new Person { Name = "Person 2", Emails = new[] { "c@gmail.com", "c@outlook.com" } },
            new Person { Name = "Person 3", Emails = new[] { "d@gmail.com", "d@outlook.com" } },
            new Person { Name = "Person 4", Emails = new[] { "e@gmail.com", "e@outlook.com" } },
        };

            var emails = data.SelectMany(p => p.Emails).ToList();
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
