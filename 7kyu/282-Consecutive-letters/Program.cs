using System;

public class Solution
{
    public static bool solve(string s)
    {
        //..
        return s.Distinct().Count() == s.Length ? s.Max() - s.Min() == s.Length - 1 : false;

        // Alternative 1
        // return Enumerable.Range(s.Min(), s.Distinct().Count()).Sum() == s.Sum(c => c);

        // Alternative 2
        // return "abcdefghijklmnopqrstuvwxyz".Contains(String.Concat(s.OrderBy(c => c)));
    }

    public static void Main()
    {
        Console.WriteLine(solve("abc"));
        Console.WriteLine(solve("abd"));
        Console.WriteLine(solve("dabc"));
        Console.WriteLine(solve("abbc"));
        Console.WriteLine(solve("adda"));
    }
}