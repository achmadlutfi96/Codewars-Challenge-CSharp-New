using System;
using System.Linq;

public static class Kata
{
    public static string HighestValue(string a, string b)
    {
        return a.Sum(x=>x) >= b.Sum(x=>x) ? a : b;
    }

    public static void Main()
    {
        Console.WriteLine(HighestValue("AaBbCcXxYyZz0189", "KkLlMmNnOoPp4567"));
    }
}