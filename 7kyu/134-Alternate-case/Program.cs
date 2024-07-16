using System;
using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static string alternateCase(string s)
    {
      return string.Concat(s.Select(x=>char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
    }

    public static void Main(){
        Console.WriteLine(alternateCase("Hello World!"));
    }
  }
}