using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashOfFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //var filePath = Path.Combine(desktop, "MusicFiles", "music1.mp3");

            //using (SHA256 sha256Hash = SHA256.Create())
            //{
            //    using (FileStream stream = File.OpenRead(filePath))
            //    {
            //        byte[] bytes = sha256Hash.ComputeHash(stream);

            //        StringBuilder builder = new StringBuilder();
            //        foreach (var item in bytes)
            //        {
            //            builder.Append(item.ToString("X2"));
            //        }
            //        string hash = builder.ToString();

            //        Console.WriteLine($"Hash of the file: {hash}");
            //    }
            //}

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = Path.Combine(desktop, "MusicFiles", "music1.mp3");
            var bufferedStream = new BufferedStream(File.OpenRead(path),1024);
            var checkSum= new SHA256CryptoServiceProvider().ComputeHash(bufferedStream);
            var output = BitConverter.ToString(checkSum).Replace("-", "");
            bufferedStream.Close();
            Console.WriteLine($"Hash is {output}");
       }
    }
}