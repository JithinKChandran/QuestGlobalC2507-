﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerator
{
    public enum ConvertTo
    {
        UpperCase,
        LowerCase,
        Swapcase
    }
    internal class Program
    {
        public static void ConvertCasing(string input, ConvertTo targetType)
        {
            switch (targetType)
            {
                case ConvertTo.LowerCase:
                    Console.WriteLine(input.ToLower());
                    break;
                case ConvertTo.UpperCase:
                    Console.WriteLine(input.ToUpper());
                    break;
            }
            
        }

        static void Main(string[] args)
        {
            ConvertCasing("Hello",ConvertTo.Swapcase);
        }
    }
}
