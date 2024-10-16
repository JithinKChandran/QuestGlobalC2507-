using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter
{
    internal class Person
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public List<Address> Addresss { get; set; }
    }
}
