using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDelegate
{
    internal class Program
    {
        static int GetNumber() => 10;
        static string Add(int a, int b) => (a + b).ToString();
        static void Main(string[] args)
        {
            //Func (with return value).
            Func<int> gn = GetNumber;
            Func<int, int, string> a = Add;

            var n = gn();
            var res = a(1,3);
        }
    }
}
