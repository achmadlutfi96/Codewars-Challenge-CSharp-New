// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
using System.Collections.Generic;

public class Kata {
  public static int[] Between(int a, int b) {
    // your code here
    // Alternative
    // return Enumerable.Range(a, b - a + 1).ToArray();

    List<int> results = new List<int>();
    for (int i = a; i <= b; i++)
    {
        results.Add(i);
    }
    return results.ToArray<int>();
  }

  public static void Main(){
    foreach (var item in Between(-2, 2))
    {
        Console.WriteLine(item);
    }
  }
}
