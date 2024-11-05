using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello world world of programming programming hello world";

            string[] words = input.Split(new char[] { ' ', ',', '!', '.', '?' });

            string[] distinctWords = words.Distinct().ToArray();

            string result = string.Join(" ", distinctWords);

            Console.WriteLine(result);
        }
    }
}
