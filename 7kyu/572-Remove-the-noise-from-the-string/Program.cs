using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Kata
{
  public static string removeNoise(string equation)
  {
    //Code goes here
    return string.Concat(equation.Where(x=>char.IsAsciiLetterOrDigit(x) || " ?.".Contains(x)));

    // Alternative
    // return Regex.Replace(equation,@"[^a-zA-Z0-9\t\. ?!]", "");
  }

  public static void Main()
  {
    Console.WriteLine(removeNoise("h%e&·%$·llo w&%or&$l·$%d.?"));
  }
}