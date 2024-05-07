using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool Digit(this string s)
    {
        return s.Length > 1 ? false : Regex.IsMatch(s, @"\d");

        // Alternative
        // return Regex.IsMatch(s, @"^\d\z");
    }

    public static void Main(){
        Console.WriteLine("a5".Digit());
        Console.WriteLine("14".Digit());
        Console.WriteLine("7".Digit());
    }
}