using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> Solve(List<string> arr)
  {
    return arr.Select(x=>x.ToLower().Where((v, i)=>(int)v-97 == i).Count()).ToList();

    // Alternative
    // return arr.Select(s => s.Where((c, i) => c % 32 == i + 1).Count()).ToList();
  }

  public static void Main(){
    // int i = (int) 'a'- 96;
    // Console.WriteLine(i);
    foreach (var item in Solve(new List<string> {"abode", "ABc", "xyzD"}))
    {
        Console.WriteLine(item);
    }
  }
}