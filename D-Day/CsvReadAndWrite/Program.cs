using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(desktop, "test", "data.csv");

            var data = new List<Person>
            {
                new Person { Name = "Raj", Age = 20 },
                new Person { Name = "Abhi", Age = 25 },
                new Person { Name = "Sam", Age = 22 }
            };

            // Write.
            using (var writer = new StreamWriter(filePath))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(data);
                }
            }

            // Read data from CSV
            var records = new List<Person>();
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader(); 
                    while (csv.Read()) 
                    {
                        var record = csv.GetRecord<Person>();
                        records.Add(record);
                    }
                }
            }

            // Display the records
            foreach (var record in records)
            {
                Console.WriteLine($"Name: {record.Name}, Age: {record.Age}");
            }

            // Manually storing to list.
            var l = File.ReadAllLines(filePath);

            var personList = new List<Person>();

            string[] headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                var person = new Person
                {
                    Name = values[0],
                    Age = int.Parse(values[1])
                };

                personList.Add(person);
            }

            // Display the contents of the list
            foreach (var person in personList)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
