using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                int num = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,4}", num++);
                }
                Console.WriteLine();
            }
        }
    }
}
