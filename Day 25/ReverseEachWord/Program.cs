using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello c# hello world hello";
            StringBuilder output = new StringBuilder();
            string[] strings = input.Split(' ');
            foreach (var s in strings)
            {
                string result = " ";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    result += s[i];
                }
                output.Append(result);
                output.Append(" ");
            }
            Console.WriteLine(output.ToString());
        }
    }
}
