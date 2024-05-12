using System;
public class Kata
{
  public static int CloseCompare(double a, double b, double margin = 0)
  {
    return Math.Abs(a-b) <= margin ? 0 : a < b ? -1 : 1;

    // Alternative
    // return Math.Abs(a - b) <= margin ? 0 : a.CompareTo(b);
  }

  public static void Main(){
    Console.WriteLine(CloseCompare(8.1, 5, 3));
  }
}