using StackUsingList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stackUsingList = new StackUsingList<int>();
                stackUsingList.Push(1);
                stackUsingList.Push(2);
                stackUsingList.Push(3);

                Console.WriteLine(stackUsingList.Pop());
                Console.WriteLine(stackUsingList.Pop()); 
                Console.WriteLine(stackUsingList.Peek()); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}