using System;
using System.Collections.Generic;

public static class Kata
{
  public static int Solve(List<int> arr)
  {
    // throw new NotImplementedException();
    return arr.Where(x=>!arr.Contains(-x)).First();

    // Alternative 1
    // return arr.Distinct().Sum();

    // Alternative 2
    // return arr.First(x => !arr.Contains(-x));
  }

  public static void Main(){
    Console.WriteLine(Solve(new List<int> {-3,1,2,3,-1,-4,-2}));
  }
}