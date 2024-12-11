using System;

public static class Kata
{
  public static double? GetSlope(Point p1, Point p2)
  {
    // throw new NotImplementedException();
    if(p1.X == p2.X || p1.Equals(p2)){
      return null;
    }
    return (p2.Y-p1.Y)/(p2.X-p1.X);

    // Alternative
    //  return p1.X == p2.X ? (double?) null : (p1.Y - p2.Y) / (p1.X - p2.X);
  }

  public static void Main()
  {
    Console.WriteLine(GetSlope(new Point(1, 1), new Point(2, 2)));
    Console.WriteLine(GetSlope(new Point(11, 1), new Point(1, 11)));

  }
}

public class Point : Object
{
  public double X;
  public double Y;
  
  public Point(double x, double y)
  {
    this.X = x;
    this.Y = y;
  }
  
  public override string ToString()
  {
    return $"({this.X}, {this.Y})";
  }
  
  public override bool Equals(object point)
  {
    // Typechecking
    if (point == null || point.GetType() != this.GetType())
    {
      return false;
    }
    
    return this.ToString() == point.ToString();
  }
}