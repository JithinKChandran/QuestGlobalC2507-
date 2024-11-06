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
            // var revWord = strings.Select(x => new string(x.Reverse().ToArray()));
            // string res = string.Join(" ", revWord);
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
