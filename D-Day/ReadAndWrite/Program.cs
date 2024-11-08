using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //var filePath = Path.Combine(desktop, "immage.png"); 
            //var targetPath = Path.Combine(desktop, "newfile.png");
            var filePath = Path.Combine(desktop, "test", "image.png");
            var targetPath = Path.Combine(desktop, "test", "newfile.png");
            byte[] content = File.ReadAllBytes(filePath);
            //File.WriteAllBytes(filePath, content);
            byte[] dataToWrite = content.Take(content.Length / 2).ToArray();
            File.WriteAllBytes(filePath, dataToWrite);

            var JsonPath = Path.Combine(desktop, "test", "data.json");
            var p = new Person() { Name = "Person 1 ", Age = 10 };
            var JsonText = JsonConvert.SerializeObject(p);
            File.WriteAllText(JsonPath, JsonText);

            var json = File.ReadAllText(JsonPath);
            Person obj = JsonConvert.DeserializeObject<Person>(json);
            Console.WriteLine(obj.Name);
        }
    }
}
