// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
public class Kata
{
  public static int FindDifference(int[] a, int[] b)
  {
    //loading...
    return Math.Abs((a[0] * a[1] * a[2])-(b[0]*b[1]*b[2]));
    // Alternative
    // return Math.Abs(a.Aggregate(1, (x,y) => x*y) - b.Aggregate(1, (x,y) => x*y));
  }
  public static void Main(){
    Console.WriteLine(FindDifference(new int[] {3, 2, 5}, new int[] {1, 4, 4}));
  }
}
