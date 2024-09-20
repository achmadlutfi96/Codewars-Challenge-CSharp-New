using System;
using System.Linq;

public class Kata
{
    public static string Pattern(int n)
    {
        return n < 1 ? "" :string.Join("\n", Enumerable.Range(1, n).Select(x=> String.Concat(Enumerable.Range(x, n-x+1).Reverse())));

        // Alternative
        // return string.Join("\n", Range(0, Math.Max(0, n)).Select(x => string.Concat(Range(0, n - x).Select(i => n - i))));
    }

    public static void Main()
    {
        Console.WriteLine(Pattern(5));
    }
}