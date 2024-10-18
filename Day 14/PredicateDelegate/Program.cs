using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Predicate Delegate: Returns a boolean, typically used for conditions.
namespace PredicateDelegate
{
    internal class Program
    {
        static bool IsNegative(int value) => value < 0;
        static  void CheckData(int data, Predicate<int> predicate)
        {
            if (predicate(data))
            {
                Console.WriteLine("Check passed");
            }
            else
            {
                Console.WriteLine("check failed");
            }
        }
        static bool IsEven(int n) => n % 2 == 0;
        static void Main(string[] args)
        {
            CheckData(5, IsNegative);
            Predicate<int> b = IsEven;
            var res = b(1);
        }
    }
}
