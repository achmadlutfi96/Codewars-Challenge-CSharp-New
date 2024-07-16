using System;
using System.Linq;

public static class Kata
{
  public static string[] Last(string x)
  {
    return x.Split(' ').OrderBy(x=>x.Last()).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(", ", Last("abc cba cab")));
  }
}