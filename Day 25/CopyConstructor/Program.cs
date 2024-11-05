using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor
        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of Person
            Person person1 = new Person("John", 30);
            person1.Display();

            // Creating a copy of person1 using the copy constructor
            Person person2 = new Person(person1);
            person2.Display();

            // Modifying the copy
            person2.Name = "Jane";
            person2.Age = 25;

            Console.WriteLine("\nAfter modifying person2:");

            // Display both objects to show they are independent
            person1.Display();
            person2.Display();
        }
    }
}
