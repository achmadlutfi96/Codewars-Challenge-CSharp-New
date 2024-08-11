using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Solve(string a, string b)
  {
    return string.Concat(a.Concat(b).Where(x=>!a.Intersect(b).Contains(x)));

    // Alternative 1
    // return Regex.Replace(a, $"[{b}]", "") + Replace(b, $"[{a}]", "");
  }

  public static void Main(){
    Console.WriteLine(Solve("xyab", "xzca"));
    Console.WriteLine(Solve("xyabb", "xzca"));
  }
}