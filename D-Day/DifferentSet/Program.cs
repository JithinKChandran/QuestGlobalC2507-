using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSet
{
    class User
    {
        //public string Age { get; init; }

        public string Name { get; private set; }
        public User() {
            Name = "test";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //var usr = new User();
            //{
            //    name = "Jhon"
            //};
            //Console.WriteLine(usr.Name);
        }
    }
}
