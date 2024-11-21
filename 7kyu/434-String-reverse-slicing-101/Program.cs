using System;
using System.Linq;

public static class Kata
{
  public static string[] ReverseSlice(string str)
  {
    return Enumerable.Range(1, str.Length).Select(v=>string.Concat(str.Substring(0,v).Reverse())).Reverse().ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ", ReverseSlice("abcde")));
  }
}