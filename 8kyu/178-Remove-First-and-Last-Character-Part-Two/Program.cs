using System;
using System.Linq;

public static class Kata
{
  public static string? Array(string s)
  {
    string[] str= s.Split(',');
    return str.Length < 3 ? null : string.Join(" ",str.Skip(1).SkipLast(1).ToArray());

    // Alternative
    // return s.Split(',').Length < 3 ? null : string.Join(" ", s.Split(',')[1..^1]);
  }

  public static void Main(){
    Console.WriteLine(Array("1,2,3"));
    Console.WriteLine(Array("1, 3"));
  }
}