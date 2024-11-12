using System;
using System.Collections.Generic;

class Program
{
    static List<List<int>> Multiply(List<List<int>> matrixA, List<List<int>> matrixB)
    {
        var result = new List<List<int>>();
        for (int i = 0; i < matrixA.Count; i++)
        {
            result.Add(new List<int>());
            for (int j = 0; j < matrixB[0].Count; j++)
            {
                int sum = 0;
                for (int k = 0; k < matrixA[0].Count; k++)
                {
                    sum += matrixA[i][k] * matrixB[k][j];
                }
                result[i].Add(sum);
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        var matrixA = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 }
        };

        var matrixB = new List<List<int>>
        {
            new List<int> { 7, 8 },
            new List<int> { 9, 10 },
            new List<int> { 11, 12 }
        };

        var result = Multiply(matrixA, matrixB);

        Console.WriteLine("Resultant Matrix:");
        foreach (var row in result)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
