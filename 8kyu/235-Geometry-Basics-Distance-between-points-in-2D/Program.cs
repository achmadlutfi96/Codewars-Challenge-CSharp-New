using System;
public class Point{
    public double X {get; set;}
    public double Y {get; set;}
    public Point(double x, double y) {
        X = x;
        Y = y;
    }
}
public class Kata
{
  public static double DistanceBetweenPoints(Point a, Point b)
  {
    return Math.Sqrt(Math.Pow(b.X-a.X,2) + Math.Pow(b.Y-a.Y,2));
  }

  public static void Main(){
    Console.WriteLine(DistanceBetweenPoints(new Point(    1,    6), new Point(  4,    2)));
  }
}
