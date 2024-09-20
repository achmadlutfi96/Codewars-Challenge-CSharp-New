using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int? UniqueSum(List<int> lst)
  {
    // throw new NotImplementedException();
    return lst.Capacity == 0 ? null : lst.Distinct().Sum();
  }

  public static void Main(){
    Console.WriteLine(UniqueSum(new List<int>() {1, 3, 8, 1, 8}));
  }
}