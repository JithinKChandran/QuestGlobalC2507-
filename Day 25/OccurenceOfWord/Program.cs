using System;
using System.Collections.Generic;

namespace OccurrenceOfWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, World! Welcome to the world of Python programming. Hello world.";
            char[] delimiters = { ' ', ',', '!', '.' };
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            Console.WriteLine("Duplicate words and their counts:");
            foreach (var item in wordCount)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
