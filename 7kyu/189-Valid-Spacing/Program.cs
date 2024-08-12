using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata 
{
  public static bool ValidSpacing(string s)
  {
    //your code
    return !s.StartsWith(' ') && !s.EndsWith(' ') && !Regex.IsMatch(s, @"  ");

    // Alternative 1
    // return s.Trim() == s && !s.Contains("  ");
    // Alternative 2
    // return Regex.IsMatch(s,@"^$|^(\w+\s)*\w+$");
  }

  public static void Main(){
    Console.WriteLine(ValidSpacing("Hello wo rld"));
  }
}