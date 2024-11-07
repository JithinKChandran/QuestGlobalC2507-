using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class StackEmptyException : Exception
    {
        public StackEmptyException() : base(" Stack Underflow") { }
    }
}
