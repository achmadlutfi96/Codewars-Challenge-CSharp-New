using System;
using System.Linq;

public class Kata
{
  public static int ConsonantCount(string str)
  {
    // ...
    return str.Where(x=>char.IsLetter(x) && !"aiueo".Contains(char.ToLower(x))).Count();

    // Alternative
    // return Regex.Matches(str.ToLower(), "[b-df-hj-np-tv-z]").Count;
  }

  public static void Main(){
    Console.WriteLine(ConsonantCount("h^$&^#$&^elLo world"));
  }
}