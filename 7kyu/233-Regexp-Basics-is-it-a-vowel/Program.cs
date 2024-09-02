using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool Vowel(this string s)
    {
        return new string[]{"a","i", "e", "o", "u"}.Contains(s.ToLower());

        // Alternative
        // return Regex.IsMatch(s,@"\A(?i)[aeiou]\z");
    }

    public static void Main(){
        Console.WriteLine("a".Vowel());
        Console.WriteLine("ou".Vowel());
    }
}