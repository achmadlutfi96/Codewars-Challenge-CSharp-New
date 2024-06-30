using System;
using System.Linq;

public static class Kata
{
  public static long SumCubes(int n)
  {
    return (long) Enumerable.Range(1, n).Sum(x=>Math.Pow(x, 3));

    // Alternative
    // return (long) Math.Pow(n*(n+1)/2,2);
  }

  public static void Main(){
    Console.WriteLine(SumCubes(3));
  }
}