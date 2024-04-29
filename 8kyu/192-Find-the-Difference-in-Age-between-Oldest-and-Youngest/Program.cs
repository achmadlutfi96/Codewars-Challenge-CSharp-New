using System;
using System.Linq;

public class Kata
{
  public static int[] DifferenceInAges(int[] ages)
  {
    return new int[] { ages.Min(), ages.Max(), ages.Max()-ages.Min()};
  }

  public static void Main(){
    foreach (var item in DifferenceInAges(new int[] {82, 15, 6, 38, 35}))
    {
        Console.WriteLine(item);
    }
  }
}