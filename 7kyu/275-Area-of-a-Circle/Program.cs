using System;
public static class Kata
{
  public static double CalculateAreaOfCircle(double radius)
  {
    if(radius <= 0) throw new ArgumentException();
    return Math.Round(Math.PI * Math.Pow(radius, 2),3);
  }

  public static void Main(){
    Console.WriteLine(CalculateAreaOfCircle(43.2673));
  }
}