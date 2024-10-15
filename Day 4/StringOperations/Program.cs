using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METHOD 1
            var res = "";
            res = string.Join(" ,", "hello", "world");
            Console.WriteLine(res);

            var arr = new string[] { "hello", "World" };
            res = string.Join(",", arr);
            Console.WriteLine(res);

            //METHOD 2
            res = string.Concat("1", "2", 3, 10.5, true);
            Console.WriteLine(res);

            var concatArr = new string[] { "hello", "hi" };
            res = string.Concat(concatArr);
            Console.WriteLine(res);


            //METHOD 3
            res = string.Format("{0} {1} {2}", "hello", "From", "C#"); // replace 0 with hello , 1 with from
            res = string.Format("{0} {1} {2} and {2}", "hello", "From", "C#", "C++"); // o/p is hello from c## and c## ,, index 2 two  times so c++ won't be there
            Console.WriteLine(res);

            // METHOD 4
            res = "hello" + "From" + "c#";
            Console.WriteLine(res);

            //METHOD 5
            var lang = "c#";
            res = $"hello from {lang}";
            Console.WriteLine(res);

            // METHOD 6
            var sb = new StringBuilder();
            sb.AppendLine("line 1");
            sb.AppendLine("line 2");
            sb.Append("no new linw");
            sb.Append("no new linw");
            sb.AppendLine();
            sb.AppendFormat("my name is {0} {1}", "jithin", "k");
            res = sb.ToString();

            Console.WriteLine(res);

            //END
        }
    }
}
