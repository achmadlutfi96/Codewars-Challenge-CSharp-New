using System;

public static class Kata
{
  public static double DbScale(double intensity)
  {
    // throw new NotImplementedException();
    return Math.Round(10 * Math.Log10((double) intensity/Math.Pow(10, -12)));
  }
  public static void Main(){
    Console.WriteLine(DbScale(100));
  }
}