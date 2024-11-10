using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<(int, int)> GeneratePairs(int m, int n) 
    {
        // user code ..
        List<(int, int)> pairs = new();
        for (int i = m; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                pairs.Add((i, j));
            }
        }
        return pairs;

        // Alternative
        // return Enumerable.Range(m, n - m + 1).SelectMany(x => Enumerable.Range(x, n - x + 1).Select(y => (x, y)));
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", GeneratePairs(2,4)));
    }  
}