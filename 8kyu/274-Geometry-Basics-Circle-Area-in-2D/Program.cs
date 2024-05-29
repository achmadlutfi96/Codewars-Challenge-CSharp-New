using System;

public static class Kata
{
  public static double CircleArea(Circle circle)
  {
    // throw new NotImplementedException();
    return  Math.Round(Math.PI * Math.Pow(circle.Radius, 2),6);
  }

  public static void Main(){
    Console.WriteLine(CircleArea(new Circle(new Point(10, 10), 30)));
    Console.WriteLine(CircleArea(new Circle(new Point(-15, 5), 12.5)));
  }
}

public class Circle
{
  public Point Center { get; private set; }
  public double Radius { get; private set; }
  
  public Circle(Point center, double radius)
  {
    this.Center = center;
    this.Radius = radius;
  }
}

public class Point
{
  public double X { get; private set; }
  public double Y { get; private set; }
  
  public Point(double x, double y)
  {
    this.X = x;
    this.Y = y;
  }
}