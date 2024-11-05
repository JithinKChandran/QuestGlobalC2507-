﻿using System;

namespace SortArrayNoBuiltIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 2, 6, 4, 3, 9 };

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}