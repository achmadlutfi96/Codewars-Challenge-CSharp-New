using System;
using System.Linq;

public static class Kata
{
  public static bool IsTuringEquation(string str)
  {
    // throw new NotImplementedException();
   ] + v[1] == v[2]; int[] v = str.Split('+','=').Select(x=>Convert.ToInt32(string.Concat(x.Reverse()))).ToArray();
    return v[0
  }

  public static void Main()
  {
    Console.WriteLine(IsTuringEquation("73+42=16"));
    Console.WriteLine(IsTuringEquation("5+8=13"));
  }
}