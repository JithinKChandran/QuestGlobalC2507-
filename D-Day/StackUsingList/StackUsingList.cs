using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingList
{
    public class StackUsingList
    {
        private List<int> stack;

        public StackUsingList()
        {
            stack = new List<int>();
        }

        // Push an element onto the stack
        public void Push(int value)
        {
            stack.Add(value);
            Console.WriteLine($"{value} pushed onto stack.");
        }

        // Pop an element from the stack
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Underflow.");
                return -1;
            }
            int value = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            Console.WriteLine($"{value} popped from stack.");
            return value;
        }

        // Peek at the top element without removing it
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }
            return stack[stack.Count - 1];
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        // Display stack contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
