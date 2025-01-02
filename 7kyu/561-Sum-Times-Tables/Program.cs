using System;
using System.Collections.Generic;

public static class Kata
{
  public static long SumTimesTable(List<int> tables, long min, long max)
  {
    long sums = 0;
    for(long i = min; i <= max; i++){
      sums += i; 
    }
    return tables.Sum()*sums;

    // Alternative
    // return tables.Sum(x => (long)x) * ((min + max) * (max - min + 1) / 2);
  }

  public static void Main()
  {
    Console.WriteLine(SumTimesTable(new List<int> {2, 3}, 1, 3));
  }
}