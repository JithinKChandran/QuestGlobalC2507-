using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 13, 73, 72, 68, 82, 0, 0, 5, 176
            string data = "This is the text to be written to the file";
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //var filePath = Path.Combine(desktop, "test", "image1.png");

            //var stream = new FileStream(filePath, FileMode.Open);
            //var header = new byte[20];
            //stream.Read(header, 0, 20);
            //Console.WriteLine(string.Join(", ", header));

            var filePath = Path.Combine(desktop, "test", "pasword.tx");
            string passwordToSearch = "123456";
            var passwords = File.ReadAllLines(filePath);
            int index = 0;
            foreach ( var password in passwords )
            {
                index++;
                if ( password == passwordToSearch)
                {
                    Console.WriteLine($"Password Found at : {index}");
                    break;
                }
            }
        }
    }
}
