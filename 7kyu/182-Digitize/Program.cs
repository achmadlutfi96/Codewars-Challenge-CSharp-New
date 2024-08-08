using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static int[] digitize(int n)
  {
    return n.ToString().Select(x=>(int)char.GetNumericValue(x)).ToArray();

    // Alternative
    // return $"{n}".Select(c => c - 48).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", digitize(10)));
  }
}