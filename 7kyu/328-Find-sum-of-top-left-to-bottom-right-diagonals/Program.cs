using System;

public static class Kata
{
    public static int DiagonalSum(int[,] matrix)
    {
        //TODO
        int res = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    res += matrix[i, j];
                }
            }
        }
        return res;

        // Alternative 1
        // return Enumerable.Range(0, matrix.GetLength(0)).Sum(i => matrix[i, i]);

        // Alternative 2
        // int result = 0;
        // for (int i = 0; i < matrix.GetLength(matrix.Rank - 1); i++)
        // {
        //     result += matrix[i, i];
        // }
        // return result;
    }

    public static void Main()
    {
        Console.WriteLine(DiagonalSum(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }));
    }
}