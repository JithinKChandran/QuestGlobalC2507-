using System;

public class StackEmptyException : Exception
    {
        public StackEmptyException() : base("Stack Underflow") { }
    }

