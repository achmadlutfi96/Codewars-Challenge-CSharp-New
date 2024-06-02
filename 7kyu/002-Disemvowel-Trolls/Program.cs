using System;
using System.Linq;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        return string.Concat(str.Where(s=>!new char[]{'a','i','u','e','o'}.Contains(Char.ToLower(s))));

        // Alternative
        // return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
    }

    public static void Main(){
        Console.WriteLine(Disemvowel("This website is for losers LOL!"));
    }
}