using System;
using System.Linq;

public static class Kata
{
  public static string OddLadder(int n)
  {
    if(n<1)
    {
        return "";
    }
    return string.Join("\n",Enumerable.Range(1, n).Where(x=>x%2 == 1).Select(x=>string.Concat(Enumerable.Repeat(x,x))));
  }

  public static void Main()
  {
    Console.WriteLine(OddLadder(6));
  }
}