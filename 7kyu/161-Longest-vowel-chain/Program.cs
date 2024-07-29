using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static int Solve(string str)
  {
    // throw new NotImplementedException();
    return Regex.Split(str, @"[^aiueo]").Select(x=>x.Length).Max();

    // Alternative
    // return Regex.Split(str, "[^aeiou]+").Max(e => e.Length);
  }

  public static void Main(){
    Console.WriteLine(Solve("suoidea"));
  }
}