using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class SampleCollection
    {
        private string[] arr = new string[10];

        // Indexer declaration
        public string this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SampleCollection collection = new SampleCollection();

            // Using the indexer to set values
            collection[0] = "Hello";
            collection[1] = "World";

            // Using the indexer to get values
            Console.WriteLine(collection[0]); // Output: Hello
            Console.WriteLine(collection[1]); // Output: World
        }
    }
}