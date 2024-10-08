using System.Collections.Generic;

public class Kata
{
  public static int OddOne(List<int> list)
  {
    // Code here
    return list.All(x=>Math.Abs(x)%2 == 0) ? -1 : list.IndexOf(list.Where(x=>Math.Abs(x)%2 == 1).First());

    // Alternative
    // return list.FindIndex(i => i % 2 != 0);
  }

  public static void Main(){
    Console.WriteLine(OddOne(new List<int> {4, -8, 98, -12, -7, 90, 100}));
    Console.WriteLine(OddOne(new List<int> {2, 4, 6, 8}));
  }
}