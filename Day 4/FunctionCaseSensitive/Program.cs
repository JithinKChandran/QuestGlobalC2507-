using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCaseSensitive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ram", "arun", "SAM" };

            Console.WriteLine("Enter a name to check:");
            string userInput = Console.ReadLine();

            if (IsNameInList(names, userInput))
            {
                Console.WriteLine("Already in list..");
            }
            else
            {
                Console.WriteLine("Not in the list.");

            }
        }
        static bool IsNameInList(string[] names, string nameToCheck)
        {
            nameToCheck = nameToCheck.ToLower();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower() == nameToCheck)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
