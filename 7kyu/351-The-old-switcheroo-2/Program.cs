using System;
using System.Linq;

public class Kata
{
    public static string Encode(string str)
    {
        return string.Concat(str.Select(x=>char.IsLetter(x) ? (char.ToLower(x)-96).ToString() : x.ToString()));

        // Alternative
        // return string.Concat(str.Select(c => char.IsLetter(c) ? $"{c % 32}" : $"{c}"));
    }

    public static void Main()
    {
        Console.WriteLine(string.Concat(Encode("this is a long string!! Please [encode] @C0RrEctly")));
    }
}