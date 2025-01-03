using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static bool SexyPrime(int x, int y)
  { 
    /* Your code here */ 
    return Math.Abs(x-y) == 6 
        && Enumerable.Range(1, x).Where(v=>x%v == 0).Count() == 2 
        && Enumerable.Range(1, y).Where(v=>y%v == 0).Count() == 2 ;
  }

  public static void Main()
  {
    Console.WriteLine(SexyPrime(5,11));
    Console.WriteLine(SexyPrime(61,67));
    Console.WriteLine(SexyPrime(7,13));
    Console.WriteLine(SexyPrime(5,7));
    Console.WriteLine(SexyPrime(1,7));
  }
}