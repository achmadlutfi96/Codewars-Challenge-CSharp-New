using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Swap(string s)
  {
    // throw new NotImplementedException();
    return string.Concat(s.Select(x=>"aiueo".Contains(x) ? char.ToUpper(x) : x));

    // Alternative
    // return Regex.Replace(s, "[aeiou]", m => m.Value.ToUpper());
  }

  public static void Main(){
    Console.WriteLine(Swap("HelloWorld!"));
  }
}