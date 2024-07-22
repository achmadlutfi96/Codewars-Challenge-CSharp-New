using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static string Capitalize(string s, List<int> idxs)
  {
    // throw new NotImplementedException();
    return string.Concat(s.Select((v,i)=>idxs.Contains(i) ? char.ToUpper(v) : v));
  }

  public static void Main(){
    Console.WriteLine(Capitalize("abcdef", new List<int> {1, 2, 5}));
  }
}