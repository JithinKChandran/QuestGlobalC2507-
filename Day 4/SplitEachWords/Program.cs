using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitEachWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            foreach (var word in words)
            {
                int count = 0;
                foreach (var item in words)
                {
                    if (word == item)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{word}: {count}");
            }
        }
    }
}
