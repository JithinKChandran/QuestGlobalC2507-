using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Finding age
            Console.WriteLine("Enter DOB in yyyy-MM-dd:");
            string input = Console.ReadLine();

            DateTime dob = DateTime.Parse(input);
            int age = DateTime.Today.Year - dob.Year;

            if (DateTime.Today < dob.AddYears(age))
            {
                age--;
            }

            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}
