using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> Spot(string s1, string s2)
  {
    // Code here
    return Enumerable.Range(0, s1.Length).Where(x=>s1[x]!=s2[x]).ToList();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ", Spot("abcdefg", "abcqetg")));
  }
}