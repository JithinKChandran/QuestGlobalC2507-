using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the height of the rectangle: ");
            int height = int.Parse(Console.ReadLine());

            int length = 10;

            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 1; i < height - 1; i++)
            {
                Console.Write("*");
                for (int j = 1; j < length - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ReadKey();
            */
            /*
            string pattern = "10_200_3";

            int sum = 0;
            int temp = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] != '_')
                {
                    int digit = pattern[i] - '0'; 
                    temp = temp * 10;           
                    temp = temp + digit;         
                }
                else
                {
                    sum += temp;
                    temp = 0;
                }
            }

            sum += temp;

            Console.WriteLine(sum);
            Console.ReadKey();
            */
            /*
            int[] numbers = new int[10];
            Console.WriteLine(numbers[0]); // 0

            int?[] nullableArray = new int?[10];
            Console.WriteLine(nullableArray[0]); // null

            int[] array1 = { 4, 5, 2, 8, 7 }; // Size = 5
            */


            /*
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                int result = array[i] * 2;
                Console.WriteLine(string.Join("result);
            }
            Console.ReadKey();
            */

            /*
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i+1}= ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int sumOfEvenNumbers = 0;
            for (int i = 0; i < 5; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumOfEvenNumbers = sumOfEvenNumbers + array[i];
                }
            }
            Console.WriteLine("Sum = " + sumOfEvenNumbers);
            Console.ReadKey();
            */
            /*
            int[] numbers = new int[1]; 
            int count = 0; 

            while (true)
            {
                if (count < 2 )
                {
                    Console.Write($"Enter a number {numbers.Length}: ");
                    Array.Resize(ref numbers, numbers.Length + 1); 
                    numbers[count] = int.Parse(Console.ReadLine());
                    count++;
                    continue;
                }
                Console.Write($"Enter a number {numbers.Length} or q to quit: ");
                string input = Console.ReadLine();
                if (input== "q")
                {
                    break; 
                }
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[count] = int.Parse(input);
                count++;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine($"Sum = {sum}");
            Console.ReadKey();
            */


            /*
            int[] array = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter number {i + 1}= ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] reverseArray = new int[6];

            for (int i = 0; i < 6; i++)
            {
                reverseArray[i] = array[6 - 1 - i];
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write(reverseArray[i] + " ");
            }
            Console.ReadKey();
            */


            /*
            Console.Write("Enter array size= ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            if (n % 2 != 0)
            {
                for (int i = 0;i <= n; i++)
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    i = i + 2;
                }
            }
            else
            {
                for (int i = 0; i < n - 1; i += 2)
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    i = i + 1;
                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();

            */


        }

    }
}

