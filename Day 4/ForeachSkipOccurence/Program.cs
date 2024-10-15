using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSkipOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');
            string[] wordsFound = new string[words.Length];
            int wordsCheckedCount = 0;
            foreach (var word in words)
            {
                if (wordsFound.Contains(word))
                {
                    continue;
                }
                int count = 0;
                foreach (var item in wordsFound)
                {
                    if (word == item)
                    {
                        count++;
                    }
                }
                wordsFound[wordsCheckedCount] = word;
                wordsCheckedCount++;
                Console.WriteLine($"{word}: {count}");
            }
        }
    }