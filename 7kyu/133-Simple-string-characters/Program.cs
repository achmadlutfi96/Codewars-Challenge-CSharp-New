using System;

public class Solution
{
    public static int[] solve(String s)
    {
        //..
        int first = s.Where(char.IsUpper).Count();
        int second = s.Where(char.IsLower).Count();
        int third = s.Where(char.IsDigit).Count();
        int fourth = s.Where(x => !char.IsLetterOrDigit(x)).Count();
        return new int[] { first, second, third, fourth };

        // Alternative
        // return new[]
        // {
        //     s.Count(char.IsUpper),
        // s.Count(char.IsLower),
        // s.Count(char.IsDigit),
        // s.Count(x => !char.IsLetterOrDigit(x))
        // };
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", solve("Codewars@codewars123.com")));
    }
}