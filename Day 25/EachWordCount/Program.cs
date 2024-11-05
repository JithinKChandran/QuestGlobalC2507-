using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EachWordCount
{
    internal class Program
    {
        static void Main()
        {
            string text = "Hello all how are you all";
            var result = text.ToLower()
                .Split(' ')
                .GroupBy(x => x);
            foreach (var group in result)
            {
                Console.WriteLine(group.Key +" "+ group.Count());
            }
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine().ToLower();
            //string[] words = input.Split(new char[] { ' ','?','.'});

            //Dictionary<string, int> countOfWords = new Dictionary<string, int>();

            //foreach (string word in words)
            //{
            //    if (countOfWords.ContainsKey(word))
            //    {
            //        countOfWords[word]++;
            //    }
            //    else
            //    {
            //        countOfWords[word] = 1;
            //    }
            //}

            //foreach (var item in countOfWords)
            //{
            //    Console.WriteLine($"{item.Key}, Count : {item.Value}");
            //}
        }
    }
}
