using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string firstName = "jithin";
            // string lastName = "chandran";
            // int age = 21;
            // string fName = $"{firstName} {lastName} is {age} year's old";
            // Console.WriteLine(fName);
            // Console.ReadKey();

            // Console.WriteLine("Hi, your name?");
            // string name = Console.ReadLine();

            // Console.WriteLine($"Hello, {name}!");
            // Console.WriteLine("Enter the first number = ");
            // int n1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the second nummber = ");
            // string num2 = Console.ReadLine();   

            // int n2 = int.Parse(num2);

            // Console.WriteLine(n1 + n2);

            // int i = 10;
            // long l = i;

            // dataypes should be compstible
            // conerting from smaller to larger or equal 
            // no possibility for dataloss or errors 

            // int age = 20;
            // if(age >= 18)
            // {
            //    Console.WriteLine("You are legal.");
            // }
            // if(!age<18)
            // {
            //    Console.WriteLine("Legal");
            // }

            // Console.WriteLine("Enter your mark:");
            // int n1 = int.Parse(Console.ReadLine());
            // if(n1 > 90)
            // {
            //     Console.WriteLine("A");
            // }
            // else if(n1 > 80)
            // {
            //   Console.WriteLine("B");
            // }
            // else if(n1 > 70)
            // {
            //     Console.WriteLine("C");
            //  }
            // else if(n1 > 60)
            // {
            //     Console.WriteLine("D");
            // }
            // else
            // {
            //     Console.WriteLine("F");
            // }
            // string s = "Hello";
            // int l = s.Length;
            // char c = s[0]; // first character
            // char lc = s.last(); // advanced based on link
            // char lc =s[s.Length - 1];

            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();

            // for (int i = 0; i < name.Length; i++)
            // {
            //     char a = name[i];
            //   if (a >= 'a' && a <= 'z')
            //     {
            //         Console.Write((char)(a - 32)); // in simple Console.Writeline(name.ToUpper());
            //    }
            /*
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            string newName = "";

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    newName +='_';
                }
                else
                {
                    newName += name[i];
                }
            }
            Console.WriteLine(newName);
            */
            /*string data = " This is a text";

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '')
                {
                    break;
                }
                Console.Write(data[i]);
            }
            Console.WriteLine();*/

            /*for (int i = 0; i < 11; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i+ 10);
            }*/

            /* int num = o;
             while (true)
             {
                 Console.WriteLine("Enter numbers to add or q to exit");
                 string data = Console.ReadLine();

                 if (data == 'Q')
                 {
                     break;
                 }
             }
             Console.WriteLine(sum);*/

            /*Console.WriteLine("Enter the pattern:");
            string pattern = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < pattern.Length; i++) // WHILE(I<PATTERN.lENGTH)
                //sum +=int.Parse(pattern[i].ToString());
                //i = i + 2;
                //console.writeline(sum)
            {
                if (pattern[i] != '_')
                {
                    sum = sum + int.Parse(pattern[i].ToString());
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();*/
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
            //var names = new string[] { "Ram", "Bob", "Jane", "Sam" };

            //Console.WriteLine("Enter a name to search:");
            //var toSearch = Console.ReadLine().ToLower().Trim();

            //bool found = false;

            //for (int i = 0; i < names.Length; i++)
            //{
            //    var n = names[i].ToLower();
            //    if (n.Contains(toSearch))
            //    {
            //        Console.WriteLine("Name found: " + names[i]);
            //        found = true;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("No names found.");
            //}
        }
    }
}
