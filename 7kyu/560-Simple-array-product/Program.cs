using System;
using System.Linq;

public class Solution
{
    public static int solve(int[][] arr)
    {
        //..
        int BiggestMax = 1;
        int BiggestMin = 1;

        for (int i = 0; i < arr.Length; ++i)
        {
            int min = arr[i].Min();
            int max = arr[i].Max();
            int[] guess = new int[] { BiggestMax * max, BiggestMax * min, BiggestMin * max, BiggestMin * min };
            BiggestMax = guess.Max();
            BiggestMin = guess.Min();
        }
        return BiggestMax > BiggestMin ? BiggestMax : BiggestMin;

        // Alternative
        // return arr.Aggregate(new[] {1}, (a, c) => a.SelectMany(x => c.Select(i => x * i)).ToArray()).Max();
    }

    public static void Main()
    {
        Console.WriteLine(solve(new int[][] { new int[] { -3, -4 }, new int[] { 1, 2, -3 } }));
    }
}