using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string input = "one, 2, three, four, 5";
            var inputItems = input.Replace(" ", "").Split(',');

            var sb = new StringBuilder();
            foreach (var item in inputItems)
            {
                if (item.Length <= 2)
                {
                    int number = int.Parse(item);
                    string text = num[num.Length - 1];
                    sb.Append($"{item}, ");
                }
                else
                {
                    sb.Append($"{item}, ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
