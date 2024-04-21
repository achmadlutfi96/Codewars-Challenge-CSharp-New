using System;
using System.Linq;

public static class Kata
{
  public static int SumOfDifferences(int[] arr)
  {
    return arr.Length == 0 ? 0 : arr.Max()-arr.Min();

    // Alternative 1
    // return arr.Any() ? arr.Max() - arr.Min() : 0;
  }

  public static void Main(){
    Console.WriteLine(SumOfDifferences(new int[] { 25, 24, -25, 2 }));
  }
}