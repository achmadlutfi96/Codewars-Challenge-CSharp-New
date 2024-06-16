using System;
using System.Linq;

public class Kata
{
  public static int Divisors(int n)
  {
    // todo
    return Enumerable.Range(1, n).Where(x=> n%x==0).Count(); 

    // Alternative
    // return Enumerable.Range(1, n).Count(x=> n%x==0);
  }

  public static void Main(){
    Console.WriteLine(Divisors(10));
  }
}