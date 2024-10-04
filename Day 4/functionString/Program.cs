using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Word to replace:");
            string old = Console.ReadLine();

            Console.WriteLine("New word:");
            string newWord = Console.ReadLine();

            string newSentence = sentence.ToLower().Replace(old, newWord);
            Console.WriteLine(newSentence);
            Console.ReadKey();
        }
    }
}
