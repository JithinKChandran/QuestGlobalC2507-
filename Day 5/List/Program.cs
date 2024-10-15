using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            // var lst = new List<int>(); // Another way to create list.

            // Adds a single elements.
            list.Add(10);

            // Adding multiple values.
            var valuesToAdd = new int[] { 1, 2, 3, 3 };
            list.AddRange(valuesToAdd);

            // Updating the element.
            list[0] = 100;

            // Deleting the element.
            // The remove the first occurance of 3.
            list.Remove(3);

            // Remove from a specific index
            list.RemoveAt(1);

            // Display

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }

            foreach (var item in list)
            {
                Console.Write(list[item]);
            }

            // Create a list with values.
            var lst2 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        }
    }
}
