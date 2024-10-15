using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var s1 = new StudentClass
            {
                Name = Console.ReadLine(),
                Age = int.Parse(Console.ReadLine()),
                Mark1 = int.Parse(Console.ReadLine()),
                Mark2 = int.Parse(Console.ReadLine())
            };

            var s2 = new StudentClass
            {
                Name = "abi",
                Age = 21,
                Mark1 = 21,
                Mark2 = 10
            };
            var s3 = new StudentClass
            {
                Name = "ajay",
                Age = 15,
                Mark1 = 25,
                Mark2 = 27
            };

            StudentClass[] students = new StudentClass[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;


            foreach (var data in students)
            {
                int total = 0;
                if (data != null)
                {
                    // Console.WriteLine($"{data.Name} {data.Mark1} {data.Mark2}");
                    total += data.Mark1 + data.Mark2;
                    Console.WriteLine($"Name : {data.Name}, Age : {data.Age}, Total marks : {total}");
                }
            }
        }
    }
}
