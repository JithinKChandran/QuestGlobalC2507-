using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var s1 = new Student();
            //s1.Name = "mr x";

            //var marks = new List<Mark>
            //{
            //    new Mark { Subject = "Eng", MarkObtained = 45 },
            //    new Mark { Subject = "chem", MarkObtained = 45 },
            //};
            //s1.Marks = marks;

            //OR

            //s1.Marks = new List<Mark>(); // or this to mark class ,  saying new list<mark> marks=<...>
            //s1.Marks.Add(new Mark { Subject = " chem", MarkObtained = 45, });
            //s1.Marks.Add(new Mark { Subject = " math", MarkObtained = 25, });

            //var s = new ClassGetSet();
            //s.Name = "John";
            //s.SetAge(25);
            //Console.WriteLine(s.GetAge());

            var p1 = new Person();
            p1.Name = "Mr X";
            p1.Email = "jocj@dkmc.com";
            var address = new List<Address>
            {
                new Address { AddressType = "Home", AddressLine1 = "kochi", AddressLine2 = " Kerala", PinCode = 65562 },
                 new Address { AddressType = "work", AddressLine1 = "kannur", AddressLine2 = " Kerala", PinCode = 65552 },
            };
            p1.Addresss = address;

        }
    }
}
