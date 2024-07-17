using System;

public static class Kata
{
  public static Func<double, double> Add(double n)
  {
    return (m)=>n+m;    
  }

  public static void Main(){
    Console.WriteLine(Add(1)(3));
  }
}