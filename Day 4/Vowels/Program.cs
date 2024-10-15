using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine().ToLower();

            string vowels = "aeiouAEIOU";

            foreach (var item in text)
            {
                if (vowels.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
