using System;
using System.Linq;

public class Pattern4
{
    public static string Pattern(int n)
    {
        return n > 0 ? string.Join("\n", Enumerable.Range(1,n).Select((v,i)=>string.Concat(Enumerable.Range(v,n-i)))) : "";
    }

    public static void Main()
    {
        Console.WriteLine(Pattern(5));
    }
}