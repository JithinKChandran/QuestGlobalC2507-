using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "listen";
            string s2 = "silent";

            if (CheckAnagram(s1, s2))
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not");
            }
        }

        static bool CheckAnagram(string string1, string string2)
        {
            if (string1.Length != string2.Length)
            {
                return false;
            }

            char[] charArray1 = string1.ToCharArray();
            char[] charArray2 = string2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            return new string(charArray1) == new string(charArray2);
        }
    }
}
