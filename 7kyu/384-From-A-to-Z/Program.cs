using System;
using System.Linq;

public class Kata
{
    public static string GimmeTheLetters(string sp)
    {
        return string.Concat(Enumerable.Range(sp.First(), sp.Last()-sp.First()+1).Select(x=>Convert.ToChar(x)));

        // Alternative 
        // return string.Concat(Enumerable.Range(sp[0], sp[2] - sp[0] + 1).Select(i => (char)i));
    }

    public static void Main()
    {
        Console.WriteLine(GimmeTheLetters("F-O"));
    }
}