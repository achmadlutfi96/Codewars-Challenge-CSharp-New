using System;
using System.Linq;

public static class Kata
{
    public static string Remove(string s)
    {
        return string.Concat(s.Replace("!",""), string.Concat(s.Where(x=>x=='!')));
        // Alternative
        // return string.Concat(s.OrderBy(c => c == '!');
    }

    public static void Main(){
        Console.WriteLine(Remove("Hi! Hi!! Hi!"));
    }
}