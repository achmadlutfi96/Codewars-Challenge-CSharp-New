using System;

public static class Kata
{
  public static bool PointInCircle(double x, double y)
  {
    return x * x + y * y < 1;
  }

  public static void Main()
  {
    Console.WriteLine(PointInCircle(0.5,0.5));
    Console.WriteLine(PointInCircle(2,0));
  }
}