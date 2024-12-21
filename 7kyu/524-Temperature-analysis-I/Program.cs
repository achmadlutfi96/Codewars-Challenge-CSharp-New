using System.Linq;
using System;

public class Kata
{
  public static int? LowestTemperature(string t)
  {
    return t == "" ? null : t.Split(" ").Min(x=>Convert.ToInt32(x));

    // Alternative
    // return t.Any() ? t.Split().Min(int.Parse) : (int?) null;
  }
}