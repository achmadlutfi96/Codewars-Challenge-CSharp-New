using System;
using System.Linq;
using System.Globalization;

public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    return string.Join(" ",phrase.Split(" ").Select(s => $"{char.ToUpper(s[0])}{s.Substring(1, s.Length-1)}"));

    // Alternative
    // return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
  }

  public static void Main(){
    Console.WriteLine("How can mirrors be real if our eyes aren't real".ToJadenCase());
  }
}