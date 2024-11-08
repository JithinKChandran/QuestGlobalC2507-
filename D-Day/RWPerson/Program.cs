using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWPerson
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var data = new List<Person>();
            //for (int i = 1; i < 101; i++)
            //{
            //    data.Add(new Person()
            //    {
            //        Name = $"User = {i}",
            //        Age = i
            //    });
            //}
            var data = "hsdhbshc";
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(desktop, "data.json");

            //var person = new Person { Id = 1, Name = "Person 1", Age = 21 };

            //var jsonText = JsonConvert.SerializeObject(person);
            //File.WriteAllText(jsonPath, jsonText);

            //var json = File.ReadAllText(jsonPath);
            //Person obj = JsonConvert.DeserializeObject<Person>(json);

            //Console.WriteLine($"ID: {obj.Id}, Name: {obj.Name}, Age: {obj.Age}");

            var stream = new FileStream(filePath, FileMode.Append);
            var writer = new StreamWriter(stream);
            while (true)
            {
                Console.WriteLine("\nDo you wish to add 1 mmore line to the file:");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    var s = $"This is a line added at {DateTime.Now}{Environment.NewLine}";

                    var dataToWrite = Encoding.UTF8.GetBytes(s);
                    writer.Write(s);
                    writer.Flush();
                }
                else
                {
                    break;
                }
                stream.Close();
            }
        }
    }
}

