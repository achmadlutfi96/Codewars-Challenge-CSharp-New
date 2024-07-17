using System;
using System.Linq;

public class Digits
{
  public static string Explode(string s)
  {
    // Insert your solution here
    return string.Concat(s.Select(x=>string.Concat(Enumerable.Repeat(x, (int)char.GetNumericValue(x)))));

    // Alternative 1
    // return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));
    // Alternative 2
    // return string.Concat(s.Select(n => new string(n, n - 48)));
  }

  public static void Main(){
    Console.WriteLine(Explode("312"));
  }
}
