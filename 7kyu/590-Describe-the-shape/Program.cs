using System;

public static class Kata
{
  public static string DescribeTheShape(int angles)
  {
    if (angles <= 2) 
    { 
      return "this will be a line segment or a dot"; 
    } 
    
    int sides = angles; // Since the number of angles in a regular polygon is equal to the number of sides. 
    int interiorAngle = (sides - 2) * 180 / sides; // Formula for the measure of each interior angle in a regular polygon. 
    
    return $"This shape has {sides} sides and each angle measures {Math.Floor((double)interiorAngle)}";

    // Alternative
    // angles < 3
      // ? "this will be a line segment or a dot"
      // : $"This shape has {angles} sides and each angle measures {Math.Floor(180 - 360d / angles)}";
  }
}