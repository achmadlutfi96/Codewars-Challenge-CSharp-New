using System;

public class Kata 
{
  public static bool Collision(double x1, double y1, double r1, double x2, double y2, double r2) 
  {
    // throw new NotImplementedException();
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)) <= r1+r2; 
  }

  public static void Main()
  {
    Console.WriteLine(Collision(1, 1, 1, 1.1, 1.1, 0.1));
    Console.WriteLine(Collision(0, 1.7, 0.36, 2.1, 2, 0.8));
  }
}