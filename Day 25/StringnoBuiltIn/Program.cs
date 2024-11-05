using System;

namespace StringnoBuiltIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            Console.WriteLine(result);
        }
    }
}
