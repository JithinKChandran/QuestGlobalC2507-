using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();
            string s = "";

            foreach (var chr in input)
            {
                char res = char.IsUpper(chr) ? char.ToLower(chr) : char.ToUpper(chr);
                s = s + res;
            }

            Console.WriteLine(s);
        }
    }
}
