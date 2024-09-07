using System.Linq;
using System;
public class Kata
{
  public static int Consecutive(int[] arr)
  {
    return arr.Length < 3 ? 0 : arr.Max()-(arr.Min()+1)-(arr.Length-2);

    // Alternative
    // return arr.Any() ? arr.Max() - arr.Min() - arr.Length + 1 : 0;
  }

  public static void Main(){
    Console.WriteLine(Consecutive(new int[] { 4, 8, 6 }));
    Console.WriteLine(Consecutive(new int[] { -1, -5 }));
  }
}