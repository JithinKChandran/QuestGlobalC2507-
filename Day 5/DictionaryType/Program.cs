using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, string> d = new Dictionary<string, string>();
            var d = new Dictionary<string, string>();

            // Adding values.
            d.Add("First Name", "Jithin");
            d.Add("Middle Name", "K");
            d.Add("Last Name", "Chandran");
            d.Add("Age", "25");

            // Accesing a value.
            Console.WriteLine(d["First Name"]);

            // Updating a value.
            d["Middle Name"] = "Koroth";
            Console.WriteLine(d["Middle Name"]);

            // Removing a value.
            d.Remove("Middle Name");

            // Check if a key exixt.
            if (d.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exists.");
            }
            else
            {
                Console.WriteLine("Doesn't exixt.");
            }

            // Looping a dictionary.
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
