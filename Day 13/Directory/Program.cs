using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Datausers";
            var fileName = "data.txt";
            var filePath = Path.Combine(path, fileName);
            Directory.CreateDirectory(path);
            Directory.Delete(path);
            Directory.Delete(path, true);
            File.Delete(filePath);
            File.Create(filePath);
            File.WriteAllText(filePath, "New Text from code.");

            //Add to the end of the existing content.
            File.AppendAllText(filePath, "New Text from code.");

            //read content from a file.
            var content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            if (Directory.Exists(path))
            {
                Console.WriteLine("Directory exixt.");
            }
            else
            {
                Console.WriteLine("Doesn't exist");
            }
        }
    }
}
