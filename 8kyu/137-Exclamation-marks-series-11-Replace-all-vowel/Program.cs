using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Replace(string s)
  {
    // throw new NotImplementedException();   
    return String.Concat(s.Select(x=>"aiueo".Contains(char.ToLower(x))?'!':x));

    // Alternative
    // return Regex.Replace(s, "[aeiouAEIOU]", "!");
  }
  public static void Main(){
    Console.WriteLine(Replace("ABCDE"));
  }
}