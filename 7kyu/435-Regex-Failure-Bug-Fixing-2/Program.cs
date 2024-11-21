using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static string filterWords(string phrase)
  {
      string pattern = @"bad|mean|ugly|horrible|hideous\b";
      string replacement = "awesome";
      Regex rgx = new Regex(pattern,  RegexOptions.IgnoreCase);
      return rgx.Replace(phrase, replacement);
  }

  public static void Main()
  {
    Console.WriteLine(filterWords("You're Meanish!! timmy!"));
  }
}