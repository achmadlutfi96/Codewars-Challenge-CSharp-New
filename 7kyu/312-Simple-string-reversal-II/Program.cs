using System;
using System.Linq;

public class Solution
{
    public static String solve(String s, int a, int b)
    {
        //..
        b = s.Length > b ? b + 1 : s.Length;
        return s[..a] + string.Concat(s[a..b].Reverse()) + s[b..];
    }

    public static void Main()
    {
        Console.WriteLine(solve("codingIsFun", 2, 100));
        Console.WriteLine(solve("codewars", 1, 5));
        Console.WriteLine(solve("FunctionalProgramming", 2, 15));
    }
}