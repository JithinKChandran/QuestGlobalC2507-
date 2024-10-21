using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int> { 1, 2, 3, 4, 5, -6, -7, 8, -9, 10 };

            // Filter even numbers
            var evenNum = num.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even Numbers:");
            foreach (var i in evenNum)
            {
                Console.WriteLine(i);
            }

            // Filter strings starting with 'A'
            var strings = new List<string> { "Apple", "Banana", "Baby", "Angle" };
            var startsWithA = strings.Where(s => s.StartsWith("A")).ToList();
            Console.WriteLine("Start with A:");
            foreach (var s in startsWithA)
            {
                Console.WriteLine(s);
            }

            // Sort numbers in descending order
            var descNum = num.OrderByDescending(n => n).ToList();
            Console.WriteLine("Descending:");
            foreach (var n in descNum)
            {
                Console.WriteLine(n);
            }

            // Square of each number
            var eachNumSqr = num.Select(n => n * n).ToList();
            Console.WriteLine("Each number Square:");
            foreach (var i in eachNumSqr)
            {
                Console.WriteLine(i);
            }

            // Square of even numbers
            var evenSqr = num.Where(n => n % 2 == 0).Select(n => n * n).ToList();
            Console.WriteLine("Even Number Square:");
            foreach (var i in evenSqr)
            {
                Console.WriteLine(i);
            }

            // Find first string starting with 'B'
            var firstWithB = strings.FirstOrDefault(s => s.StartsWith("B"));
            Console.WriteLine(firstWithB != null ? $"First string starting with 'B': {firstWithB}" : "Nothing starts with 'B'.");

            // Students scoring above 80
            var names = new List<string> { "Alice", "Bob" };
            var grades = new List<int> { 85, 78 };
            var studentsAbove80 = names.Where((name, index) => grades[index] > 80).ToList();
            Console.WriteLine("Students scoring above 80: " + string.Join(", ", studentsAbove80));

            // Group words by length
            var groupedByLength = strings.GroupBy(s => s.Length);
            Console.WriteLine("Grouped By Length:");
            foreach (var group in groupedByLength)
            {
                Console.WriteLine($"Length {group.Key}: {string.Join(", ", group)}");
            }

            // Find maximum value
            var maxValue = num.Max();
            Console.WriteLine("Max value: " + maxValue);

            // Find minimum value
            var minValue = num.Min();
            Console.WriteLine("Min value: " + minValue);

            // Check for numbers greater than 50
            var greaterThanFifty = num.Where(n => n > 50).ToList();
            Console.WriteLine("Greater than 50:");
            foreach (var i in greaterThanFifty)
            {
                Console.WriteLine(i);
            }

            // Check if all numbers are positive
            var allPositive = num.All(n => n > 0);
            Console.WriteLine("Are all numbers positive? " + allPositive);

            // Sum of all elements
            var sum = num.Sum();
            Console.WriteLine("Sum: " + sum);

            // Calculate average
            var average = num.Average();
            Console.WriteLine("Average: " + average);

            // Remove duplicates
            var distinctNumbers = num.Distinct().ToList();
            Console.WriteLine("Distinct Numbers:");
            foreach (var i in distinctNumbers)
            {
                Console.WriteLine(i);
            }

            // Count elements greater than 10
            var countGreaterThanTen = num.Count(n => n > 10);
            Console.WriteLine("Count of numbers greater than 10: " + countGreaterThanTen);

            // Skip and take elements
            var skipAndTake = num.Skip(5).Take(3).ToList();
            Console.WriteLine("Skip and Take:");
            foreach (var i in skipAndTake)
            {
                Console.WriteLine(i);
            }

            // Zip two lists together
            var lst1 = new List<string> { "a", "b", "c" };
            var lst2 = new List<int> { 1, 2, 3 };
            var zipped = lst1.Zip(lst2, (first, second) => new { First = first, Second = second }).ToList();
            Console.WriteLine("Zipped Lists:");
            foreach (var pair in zipped)
            {
                Console.WriteLine($"({pair.First}, {pair.Second})");
            }
        }
    }
}
