using System;
using System.Linq;

public class Kata
{
  public static int FindDup(int[] arr)
  {
    return arr.Distinct().Where(x=>arr.Where(y=>x==y).Count() > 1).First();
  }

  public static void Main(){
    Console.WriteLine(FindDup(new int[] {1, 1, 2, 3}));
  }
}