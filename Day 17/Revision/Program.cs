using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class Calculator
    {
        // Private member variable
        private double result;

        // Protected method to reset the result
        protected void ResetResult()
        {
            result = 0;
        }

        // Public method to add two numbers
        public double Add(double a, double b)
        {
            ResetResult(); // Use the protected method
            result = a + b;
            return result;
        }

        // Method to display the current result
        public void DisplayResult()
        {
            Console.WriteLine($"The result is: {result}");
        }
    }

    public class AdvancedCalculator : Calculator
    {
        // Public method to use the Add method from the base class
        public void AddAndDisplay(double a, double b)
        {
            double sum = Add(a, b); // Inherited Add method
            Console.WriteLine($"The sum of {a} and {b} is: {sum}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var calc = new AdvancedCalculator();

            // Perform addition and display result
            calc.AddAndDisplay(5, 10);

            // Trying to access the private member 'result' directly will result in an error
            // calc.result = 15; // Uncommenting this line will cause a compilation error

            // Trying to call the protected method directly will also result in an error
            // calc.ResetResult(); // Uncommenting this line will cause a compilation error
        }

    }
}
