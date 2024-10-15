using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string:");
            string text = Console.ReadLine();
            var reverse = string.Concat(text.Reverse());
            if (text == reverse)
            {
                Console.WriteLine("palindrome.");
            }
            else
            {
                Console.WriteLine("Not a palindrome.");

            }
        }
    }
}
