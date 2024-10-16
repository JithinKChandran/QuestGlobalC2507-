using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter
{
    internal class Student
    {
        public string Name { get; set; }
        public List<Mark> Marks { get; set; }

        //private int age;

        //public int Age
        //{
        //    get => age;
        //    set
        //    {
        //        if (value < 0 && value < 50)
        //        {
        //            age = value;
        //        }
        //    }
        //}

        //public int GetAge() => age;

        //public void SetAge(int value)
        //{
        //    if (value < 0 && value < 50)
        //    {
        //        age = value;
        //    }
        //}


        // making id pulblic, but restricting id values like putting a condition.

        //private string id;

        //public string Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
    }
}
