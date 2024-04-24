using System;

public static class Kata
{
  public static int NearestSq(int n)
  {
    // throw new NotImplementedException("NearestSq is not implemented.");
    return (int) Math.Pow(Math.Round(Math.Sqrt(n)), 2);
  }

  public static void Main(){
    Console.WriteLine(NearestSq(111));
  }
}