// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    //Insert brain here
    return ClassPoints.Average() < YourPoints;
  }
  public static void Main(){
    Console.WriteLine(BetterThanAverage(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 75));
  }
}