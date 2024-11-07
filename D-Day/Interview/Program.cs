using Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImpArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                var stackUsingArray = new StackUsingArray<int>(3);
                stackUsingArray.Push(1);
                stackUsingArray.Push(2);
                stackUsingArray.Push(3);
                //stackUsingArray.Push(4);

                Console.WriteLine(stackUsingArray.Pop());
            }
			catch (Exception e)
			{

                Console.WriteLine(e.Message);
			}
        }
    }
}
