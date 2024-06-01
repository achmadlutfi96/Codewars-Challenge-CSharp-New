using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        // Your code here
        return str.Where(s => new char[]{'a','e', 'i', 'o', 'u'}.Contains(s)).Count();

        // Alternative
        // return str.Count(i => "aeiou".Contains(i));
    }

    public static void Main(){
        Console.WriteLine(GetVowelCount("abracadabra"));
    }
}