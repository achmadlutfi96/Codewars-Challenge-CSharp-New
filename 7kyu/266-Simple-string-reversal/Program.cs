using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public static String solve(String s)
    {
        //..
        int[] lengthString = s.Split(" ").Select(x => x.Length).ToArray();
        List<string> results = new();
        string result = string.Concat(s.Replace(" ", "").Reverse());
        Console.WriteLine(string.Join(",", lengthString));
        int i = 0;
        int j = 0;
        while (result.Length > i)
        {
            results.Add(result.Substring(i, lengthString[j]));
            i += lengthString[j];
            j++;
        }
        return string.Join(" ", results);

        //   Alternative
        // return s.Select((c, i) => (c, i)).Where(x => x.c == ' ')
        //   .Aggregate(string.Concat(s.Replace(" ", "").Reverse()), (r, x) => r.Insert(x.i, " "));
    }

    public static void Main()
    {
        Console.WriteLine(solve("your code rocks"));
    }
}