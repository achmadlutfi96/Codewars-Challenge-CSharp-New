using System;
using System.Linq;

public class SuffPref
{
    public static int solve(string s)
    {
        //..
        for (int i = s.Length / 2; i > 0; i--)
        {
            if (s.Substring(0, i).Equals(s.Substring(s.Length - i)))
            {
                return i;
            }
        }
        return 0;

        // Alternative
        // return Enumerable.Range(1, s.Length / 2).Where(i => s[..i] == s[^i..]).DefaultIfEmpty(0).Max();
    }

    public static void Main()
    {
        Console.WriteLine(solve("abcd"));
        Console.WriteLine(solve("abcda"));
        Console.WriteLine(solve("abcdabc"));
        Console.WriteLine(solve("abcabc"));
        Console.WriteLine(solve("aaaa"));
    }
}