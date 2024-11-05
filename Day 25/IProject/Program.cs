using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using IEnumerable
            IEnumerable<int> numberEnumerable = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nIEnumerable demonstration:");
            foreach (var number in numberEnumerable)
            {
                Console.WriteLine(number);
            }
            // Using ICollection
            ICollection<int> numberCollection = new List<int> { 6, 7, 8, 9, 10 };
            Console.WriteLine("\nICollection demonstration:");
            numberCollection.Add(11);   // Adding element
            numberCollection.Remove(9); // Removing element
            Console.WriteLine($"Count: {numberCollection.Count}");

            // Using IList
            IList<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("IList demonstration:");
            numberList.Insert(2, 99);  // Inserting element at index 2
            numberList.RemoveAt(4);    // Removing element at index 4
            Console.WriteLine($"Element at index 2: {numberList[2]}");  
        }
    }
}