using System;
using System.Linq;
public class Kata
{
  public static int? Closest(int[] arr)
  {
    // return null if it is not possible to return 1 unique closest value
    int min = arr.Min(Math.Abs);
    int[] res = arr.Where(x=>Math.Abs(x) == min).ToArray();
    return res.Any(x=>x < 0) && res.Any(x=> x > 0) ? null : res.First();

    // Alternative 
    // var min = arr.Distinct().Where(x => Math.Abs(x) == arr.Min(Math.Abs));
    // return min.Count() == 1 ? min.First() : (int?) null;
  }

  public static void Main()
  {
    Console.WriteLine(Closest(new int[] {10, 3, 9, 1}));
  }
}