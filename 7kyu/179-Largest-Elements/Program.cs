using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> Largest(int n, List<int> xs)
  {
    // Find the n highest elements in a list
    return xs.OrderBy(x=>x).TakeLast(n).ToList();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", Largest(3, new List<int> {5, 1, 5, 2, 3, 1, 2, 3, 5})));
  }
}