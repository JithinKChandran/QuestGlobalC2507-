using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = "Pass@123";
            var input = Encoding.Default.GetBytes(password);

            var hash1 = new MD5CryptoServiceProvider().ComputeHash(input);
            var builder = new StringBuilder();
            foreach ( var item in hash1 )
            {
                builder.Append(item.ToString("X2"));
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
