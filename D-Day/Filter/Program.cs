using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("search: ");
            string searchString = Console.ReadLine();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string[] files = Directory.GetFiles(desktopPath, "*" + searchString + "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
