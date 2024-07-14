using System;
using System.Linq;

public class Kata
{
  public static int FindSmallest(int[] numbers, string toReturn)
  {
    //Code Me
    return toReturn == "index" ? Array.IndexOf(numbers, numbers.Min()) : numbers.Min();
  }

  public static void Main(){
    Console.WriteLine(FindSmallest(new int[]{ 5, 4, 3, 2, 1}, "index"));
  }
}