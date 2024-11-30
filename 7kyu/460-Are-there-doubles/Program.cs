using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool Double_check(string strng)
    {
        // Your Code
        return strng.Distinct().Any(x=>strng.ToLower().Contains($"{x}{x}"));

        // Alternative
        // return Regex.IsMatch(s,@"(?i)(.)\1");
    }

    public static void Main()
    {
        Console.WriteLine(Double_check("a 11 c d"));
        Console.WriteLine(Double_check("2020"));
        Console.WriteLine(Double_check("a b  c"));

    }
}