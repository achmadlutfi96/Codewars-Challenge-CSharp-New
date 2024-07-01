using System;
using System.Linq;

public class Kata
{
  public static int Triangular(int n)
  {
    return n > 0 ? Enumerable.Range(1,n).Sum(i => i) : 0;

    // Alternative
    // return n < 0 ? 0 : n*(n+1)/2;
  }

  public static void Main(){
    Console.WriteLine(Triangular(2));
  }
}