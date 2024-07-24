using System;
using System.Linq;

public class Kata
{
  public static int DifferenceOfSquares(int n)
  {
    // ...
    return (int) (Math.Pow(Enumerable.Range(1, n).Sum(),2) - Enumerable.Range(1,n).Select(x=>Math.Pow(x,2)).Sum());

    // Alternative 1
    // return n * (n + 1) * (3 * n * n - n - 2) / 12;
    // Alternative 2
    // return (x*(x+1)/2)*(x*(x+1)/2) - (2*x+1)*(x+1)*x/6;

  }

  public static void Main(){
    Console.WriteLine(DifferenceOfSquares(5));
  }
}