using System;
using System.Linq;
public class Kata
{
  public static bool AmIWilson(int p)
  {
    return (Enumerable.Range(1, p-1).Aggregate(1, (n, item) => n * item) + 1 ) % ( p * p ) == 0; 

    // Alternative
    // return p == 5 || p == 13 || p == 563;
  }

  public static void Main(){
    Console.WriteLine(AmIWilson(5));
    Console.WriteLine(AmIWilson(9));
  }
}